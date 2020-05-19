using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageManipulation
{
	public partial class MainForm : Form
	{		
		private Bitmap lastImage;
		
		public MainForm()
		{
			InitializeComponent();
			
			partOnePage.Tag = partOneControl;
			partTwoPage.Tag = partTwoControl;
			partThreePage.Tag = partThreeControl;
			partFourPage.Tag = partFourControl;
			partFivePage.Tag = partFiveControl;
		}
		
		private Bitmap OpenImageFile()
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					return new Bitmap(ofd.FileName);
				}
				catch
				{
					MessageBox.Show("File is not a valid image!", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
			return null;
		}
		
		void GenerateButtonClick(object sender, EventArgs e)
		{
			Bitmap image = OpenImageFile();
			
			if (image != null)
			{
				IPartControl control = (IPartControl)tabControl1.SelectedTab.Tag;
				lastImage = image;
				control.Image = image;
				control.Generate();
			}
		}
		
		void RefreshButtonClick(object sender, EventArgs e)
		{
			if (lastImage != null)
			{
				IPartControl control = (IPartControl)tabControl1.SelectedTab.Tag;
				control.Image = lastImage;
				control.Generate();
			}
		}
	}
}
