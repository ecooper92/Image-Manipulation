using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImageManipulation.ImageAlgorithms
{
	public class UniformPartitionAlgorithm
	{				
		public void GetImage(Bitmap bitmap, int redBits, int greenBits, int blueBits) 
		{
			ImageData data = ImageUtilities.LockBitmap(bitmap);
			GetImage(data, redBits, greenBits, blueBits);
			ImageUtilities.UnlockBitmap(data);
		}
		
		private void GetImage(ImageData data, int redBits, int greenBits, int blueBits) 
		{
			ColorData[] colorTable = BuildColorLookupTable(redBits, greenBits, blueBits);
			
			int totalBits = redBits + greenBits + blueBits;
			
			for (int i = 0; i < data.RGBValues.Length; i += 3) 
			{
				int key = (int)(data.RGBValues[i + 2] / (256 / Math.Pow(2, redBits))) << (totalBits - redBits);
                key |= (int)(data.RGBValues[i + 1] / (256 / Math.Pow(2, greenBits))) << (totalBits - redBits - greenBits);
                key |= (int)(data.RGBValues[i] / (256 / Math.Pow(2, blueBits)));
				
				ColorData color = colorTable[key];
				
				data.RGBValues[i] = (byte)color.Blue;
                data.RGBValues[i + 1] = (byte)color.Green;
                data.RGBValues[i + 2] = (byte)color.Red;
			}
		}

        private ColorData[] BuildColorLookupTable(int redBits, int greenBits, int blueBits)
		{
			int redSections = (int)Math.Pow(2, redBits);
			int greenSections = (int)Math.Pow(2, greenBits);
			int blueSections = (int)Math.Pow(2, blueBits);
			
            ColorData[] colorTable = new ColorData[redSections * greenSections * blueSections];
			
			int totalBits = redBits + greenBits + blueBits;

            int rb = 256 / redSections;
            int gb = 256 / greenSections;
			int bb = 256 / blueSections;
			
			for (int r = 0; r < redSections; r++)
			{
				for (int g = 0; g < greenSections; g++)
				{
					for (int b = 0; b < blueSections; b++)
					{
						int key = r << (totalBits - redBits);
						key |= g << (totalBits - redBits - greenBits);
						key |= b;
						
						int redMiddle = rb * r + rb / 2;
						int greenMiddle = gb * g + gb / 2;
						int blueMiddle = bb * b + bb / 2;
						
						colorTable[key] = new ColorData(redMiddle, greenMiddle, blueMiddle);
					}
				}
			}
			
			return colorTable;
		}
	}
}
