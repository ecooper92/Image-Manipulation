using System;
using System.Drawing;
using System.Windows.Forms;
using ImageManipulation.ImageAlgorithms;

namespace ImageManipulation
{
	public partial class PartFourControl : UserControl, IPartControl
	{
		private readonly UniformPartitionAlgorithm uniformPartition = new UniformPartitionAlgorithm();
		
		public PartFourControl()
		{
			InitializeComponent();
		}
        
		public Bitmap Image { get; set; }

		public void Generate()
		{
			Bitmap newImage = new Bitmap(Image);
            uniformPartition.GetImage(newImage, redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
			oldPictureBox.Image = Image;
			newPictureBox.Image = newImage;
		}
		
		void BlueTrackBarValueChanged(object sender, EventArgs e)
		{
			blueBitsLabel.Text = "Blue: " + blueTrackBar.Value;
		}
		void GreenTrackBarValueChanged(object sender, EventArgs e)
		{
			greenBitsLabel.Text = "Green: " + greenTrackBar.Value;
		}
		void RedTrackBarValueChanged(object sender, EventArgs e)
		{
			redBitsLabel.Text = "Red: " + redTrackBar.Value;
		}
	}
}
