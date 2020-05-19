using System;
using System.Drawing;
using System.Windows.Forms;
using ImageManipulation.ImageAlgorithms;

namespace ImageManipulation
{
	public partial class PartFiveControl : UserControl, IPartControl
	{
		private readonly MedianCutAlgorithm medianCut = new MedianCutAlgorithm();
		
		public PartFiveControl()
		{
			InitializeComponent();
		}

		public Bitmap Image { get; set; }

		public void Generate()
		{
			oldPictureBox.Image = Image;
			
			Bitmap newImage = new Bitmap(Image);
			medianCut.GetImage(newImage, bitsTrackBar.Value);
			
			newPictureBox.Image = newImage;
		}
		
		void BitsTrackBarValueChanged(object sender, EventArgs e)
		{
			bitsLabel.Text = "Bits: " + bitsTrackBar.Value;
		}
	}
}
