using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulation
{
	public partial class PartTwoControl : UserControl, IPartControl
	{
		public PartTwoControl()
		{
			InitializeComponent();
		}

		public Bitmap Image  { get; set; }

		public void Generate()
		{
			if (Image != null) 
			{
				originalPictureBox.Image = Image;
				
				Bitmap rgbImage = new Bitmap(Image);
				GetPaletteImage(rgbImage, PaletteMode.RGB);
				
				Bitmap brgImage = new Bitmap(Image);
				GetPaletteImage(brgImage, PaletteMode.BRG);
				
				Bitmap gbrImage = new Bitmap(Image);
				GetPaletteImage(gbrImage, PaletteMode.GBR);
				
				imageFlipper.SetImages(new List<Image>() { brgImage, gbrImage, rgbImage });
			}
			else throw new ArgumentNullException("Image has not been set");
		}
		
		private void GetPaletteImage(Bitmap bitmap, PaletteMode pm) 
		{
			ImageData data = ImageUtilities.LockBitmap(bitmap);
			GetPaletteImage(data, pm);
			ImageUtilities.UnlockBitmap(data);
		}
		
		private void GetPaletteImage(ImageData data, PaletteMode pm) 
		{
			int mode = (int)pm;
			for (int i = 0; i < data.RGBValues.Length; i += 3) 
			{
				byte red = data.RGBValues[i + 2];
				byte green = data.RGBValues[i + 1];
				byte blue = data.RGBValues[i];
				
				data.RGBValues[i + mode] = blue;
				data.RGBValues[i + ((1 + mode) % 3)] = green;
				data.RGBValues[i + ((2 + mode) % 3)] = red;
			}
		}
	}
}
