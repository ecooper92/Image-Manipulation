using System;
using System.Drawing;
using System.Windows.Forms;
using ImageManipulation.ImageAlgorithms;

namespace ImageManipulation
{
	/// <summary>
	/// Description of PartThreeControl.
	/// </summary>
	public partial class PartThreeControl : UserControl, IPartControl
	{
		private GrayscaleAlgorithm grayscale = new GrayscaleAlgorithm();
		private ErrorDiffusionAlgorithm errorDiffusion = new ErrorDiffusionAlgorithm();
		
		public PartThreeControl()
		{
			InitializeComponent();
		}

		public Bitmap Image { get; set; }

		public void Generate()
		{
			if (Image != null)
			{
				Bitmap grayScale = new Bitmap(Image);
				grayscale.GetImage(grayScale);
				
				originalPictureBox.Image = grayScale;	

				Bitmap diffusion = new Bitmap(grayScale);
				errorDiffusion.GetImage(diffusion);
				
				processedPictureBox.Image = diffusion;
			}
		}
	}
}
