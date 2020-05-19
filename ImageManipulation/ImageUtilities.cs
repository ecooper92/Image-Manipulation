using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using ImageManipulation;

namespace ImageManipulation
{
	public static class ImageUtilities
	{
		public static ImageData LockBitmap(Bitmap bitmap) 
		{
            ImageData data = new ImageData();
            data.Image = bitmap;
            
            data.BitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int numBytes = data.BitmapData.Stride * bitmap.Height;
            data.RGBValues = new byte[numBytes];

            Marshal.Copy(data.BitmapData.Scan0, data.RGBValues, 0, numBytes);
            
            return data;
		}
		
		public static void UnlockBitmap(ImageData data) 
		{
            int numBytes = data.BitmapData.Stride * data.Image.Height;
            Marshal.Copy(data.RGBValues, 0, data.BitmapData.Scan0, numBytes);
            data.Image.UnlockBits(data.BitmapData);
		}
	}
}
