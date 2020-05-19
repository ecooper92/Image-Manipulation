using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageManipulation
{
	/// <summary>
	/// Represents locked bitmap data including the original image, the data,
	/// and the RGB Values.
	/// </summary>
	public class ImageData
	{
		/// <summary>
		/// The currently locked image used to create this image data.
		/// </summary>
		public Bitmap Image { get; set; }
		
		/// <summary>
		/// The data and properties of the locked image.
		/// </summary>
		public BitmapData BitmapData { get; set; }
		
		/// <summary>
		/// The current RGB Values of the locked image.
		/// </summary>
		public byte[] RGBValues { get; set; }
	}
}
