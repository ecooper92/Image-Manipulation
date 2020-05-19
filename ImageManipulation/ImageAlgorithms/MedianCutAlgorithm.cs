using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;

namespace ImageManipulation.ImageAlgorithms
{
	public class MedianCutAlgorithm
	{
		public void GetImage(Bitmap bitmap, int bits)
		{
			ImageData data = ImageUtilities.LockBitmap(bitmap);
			GetImage(data, bits);
			ImageUtilities.UnlockBitmap(data);
		}
		
		private void GetImage(ImageData data, int bits) 
		{
			int bitCount = (int)Math.Pow(2, bits);
			
			List<ColorDataBox> boxes = new List<ColorDataBox>();
			
			ColorData[] colors = new ColorData[data.RGBValues.Length / 3];
			for (int i = 0; i < data.RGBValues.Length; i += 3)
				colors[i / 3] = new ColorData(data.RGBValues[i + 2], data.RGBValues[i + 1], data.RGBValues[i]);
			
			ColorDataBox totalBox = new ColorDataBox(colors);
			boxes.Add(totalBox);
			
			for (int i = 0; i < bitCount - 1; i++)
			{
				int index = GetLargestBox(boxes);
				ColorDataBox box = boxes[index];
				boxes.RemoveAt(index);
				
				ColorChannel channel = ColorChannel.Red;
				if (box.LengthR >= box.LengthG && box.LengthR >= box.LengthB)
					channel = ColorChannel.Red;
				else
				{
					if (box.LengthG >= box.LengthB)
						channel = ColorChannel.Green;
					else
						channel = ColorChannel.Blue;
				}
				
				List<ColorData>[] colorTable = CountSort(box, channel);
				List<ColorData> box1 = new List<ColorData>();
				List<ColorData> box2 = new List<ColorData>();
				
				int sum = 0;
			    int half = box.ColorData.Length/2;
				foreach (List<ColorData> colorData in colorTable)
				{
				    if (sum < half)
				    {
				        if (sum + colorData.Count > half)
				        {
				            int diff = sum + colorData.Count - half;
				            box1.AddRange(colorData.GetRange(0, diff));
				            box2.AddRange(colorData.GetRange(diff, colorData.Count - diff));
				        }
				        else
				        {
				            box1.AddRange(colorData);
				        }
				    }
				    else
                    {
                        box2.AddRange(colorData);
				    }
					sum += colorData.Count;
				}
				
				boxes.Add(new ColorDataBox(box1.ToArray()));
				boxes.Add(new ColorDataBox(box2.ToArray()));
			}
			
			Dictionary<int, ColorData> medianCutTable = GetMedianCutTable(boxes);
			int[,,] indexTable = new int[256,256,256];
			
			for (int r = 0; r < 256; r++)
			{
				for (int g = 0; g < 256; g++)
				{
					for (int b = 0; b < 256; b++)
					{
						indexTable[r,g,b] = -1;
					}
				}
			}
			
			for (int i = 0; i < data.RGBValues.Length; i += 3)
			{
				ColorData colorData = colors[i / 3];
				
				int index = indexTable[colorData.Red, colorData.Green, colorData.Blue];
				if (index == -1)
				{
					index = GetContainingBox(colorData, boxes);
					indexTable[colorData.Red, colorData.Green, colorData.Blue] = index;
				}
					
				ColorData newColor = medianCutTable[index];
				
				data.RGBValues[i + 2] = (byte)newColor.Red;
				data.RGBValues[i + 1] = (byte)newColor.Green;
				data.RGBValues[i] = (byte)newColor.Blue;
			}
		}
		
		private int GetContainingBox(ColorData colorData, List<ColorDataBox> boxes)
		{
			for (int i = 0; i < boxes.Count; i++)
			{
				if (boxes[i].Contains(colorData))
					return i;
			}
			
			return -1;
		}
		
		private Dictionary<int, ColorData> GetMedianCutTable(List<ColorDataBox> boxes)
		{
			Dictionary<int, ColorData> medianCutTable = new Dictionary<int, ColorData>();
			for (int i = 0; i < boxes.Count; i++)
			{
				ColorDataBox box = boxes[i];
				int centerR = box.MinR + box.LengthR / 2;
				int centerG = box.MinG + box.LengthG / 2;
				int centerB = box.MinB + box.LengthB / 2;
				
				medianCutTable.Add(i, new ColorData(centerR, centerG, centerB));
			}
			return medianCutTable;
		}
		
		private int GetLargestBox(List<ColorDataBox> boxes)
		{
			int index = -1;
			int max = int.MinValue;
			
			for (int i = 0; i < boxes.Count; i++)
			{
				int size = boxes[i].Size;
				
				if (size > max)
				{
					max = size;
					index = i;
				}
			}
			
			return index;
		}
		
		private List<ColorData>[] CountSort(ColorDataBox box, ColorChannel cc)
		{
			List<ColorData>[] colorTable = new List<ColorData>[256];
			for (int i = 0; i < 256; i++)
				colorTable[i] = new List<ColorData>();
			
			for (int i = 0; i < box.ColorData.Length; i++)
			{
				ColorData data = box.ColorData[i];
				colorTable[data.GetValue(cc)].Add(data);
			}
			
			return colorTable;
		}
	}
}
