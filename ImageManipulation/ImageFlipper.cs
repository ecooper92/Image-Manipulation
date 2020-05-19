using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulation
{
	public partial class ImageFlipper : UserControl
	{
		private List<Image> images = new List<Image>();
		private int index = 0;
		
		public ImageFlipper()
		{
			InitializeComponent();
		}
		
		public void SetImages(List<Image> value)
		{
			if (value != null)
				images = new List<Image>(value);
			else
				images.Clear();
			
			index = 0;
			
			if (images.Count > 0)
				pictureBox.Image = images[index];
		}
		
		public void NextImage()
		{
			if (images.Count > 0)
			{
				index = (index + 1) % images.Count;
				pictureBox.Image = images[index];
			}
		}
		
		public void PrevImage()
		{
			if (images.Count > 0)
			{
				index--;
				if (index < 0)
					index = images.Count - 1;
				
				pictureBox.Image = images[index];
			}
		}
		
		void PrevButtonClick(object sender, EventArgs e)
		{
			PrevImage();
		}
		
		void NextButtonClick(object sender, EventArgs e)
		{
			NextImage();
		}
	}
}
