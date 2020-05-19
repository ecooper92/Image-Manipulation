using System;
using System.Drawing;

namespace ImageManipulation.ImageAlgorithms
{
	/// <summary>
	/// Description of ErrorDiffusionAlgorithm.
	/// </summary>
	public class ErrorDiffusionAlgorithm
	{
		public void GetImage(Bitmap bitmap)
		{
			ImageData data = ImageUtilities.LockBitmap(bitmap);
			GetImage(data);
			ImageUtilities.UnlockBitmap(data);
		}
		
		private void GetImage(ImageData data) 
		{
			byte[] rgb = data.RGBValues;
			for (int i = 0; i < rgb.Length; i+=3)
			{
				byte value = (byte)(rgb[i] * 0.07 + rgb[i + 1] * 0.72 + rgb[i + 2] * 0.21);
				rgb[i] = value;
				rgb[i + 1] = value;
				rgb[i + 2] = value;
			}
		}
	}
}
