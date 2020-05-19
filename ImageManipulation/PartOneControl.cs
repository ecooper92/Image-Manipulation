/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 10:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulation
{
	/// <summary>
	/// Description of PartOneControl.
	/// </summary>
	public partial class PartOneControl : UserControl, IPartControl
	{
		public PartOneControl()
		{
			InitializeComponent();
		}
		
		public Bitmap Image { get; set; }
		
		public void Generate()
		{
			if (Image != null) 
			{
				originalPictureBox.Image = Image;
				
				Bitmap redImage = new Bitmap(Image);
				GetChannelImage(redImage, ColorChannel.Red);
				
				Bitmap greenImage = new Bitmap(Image);
				GetChannelImage(greenImage, ColorChannel.Green);
				
				Bitmap blueImage = new Bitmap(Image);
				GetChannelImage(blueImage, ColorChannel.Blue);
				
				imageFlipper.SetImages(new List<Image>() { redImage, greenImage, blueImage });
			}
			else throw new ArgumentNullException("Image has not been set");
		}
		
		private void GetChannelImage(Bitmap bitmap, ColorChannel cc) 
		{
			ImageData data = ImageUtilities.LockBitmap(bitmap);
			GetChannelImage(data, cc);
			ImageUtilities.UnlockBitmap(data);
		}
		
		private void GetChannelImage(ImageData data, ColorChannel cc) 
		{
			for (int i = 0; i < data.RGBValues.Length; i += 3) 
			{
				if (cc == ColorChannel.Red) 
				{
					data.RGBValues[i] = 0;
					data.RGBValues[i + 1] = 0;
				}
				else if (cc ==ColorChannel.Green)
				{
					data.RGBValues[i] = 0;
					data.RGBValues[i + 2] = 0;
				}
				else if (cc ==ColorChannel.Blue)
				{
					data.RGBValues[i + 1] = 0;
					data.RGBValues[i + 2] = 0;
				}
			}
		}
	}
}
