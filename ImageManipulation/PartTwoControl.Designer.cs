/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 1:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageManipulation
{
	partial class PartTwoControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private ImageManipulation.ImageFlipper imageFlipper;
		private System.Windows.Forms.TableLayoutPanel leftLayoutPanel;
		private System.Windows.Forms.PictureBox originalPictureBox;
		private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		public void InitializeComponent()
		{
			this.outerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.imageFlipper = new ImageManipulation.ImageFlipper();
			this.leftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.originalPictureBox = new System.Windows.Forms.PictureBox();
			this.outerLayoutPanel.SuspendLayout();
			this.leftLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// outerLayoutPanel
			// 
			this.outerLayoutPanel.ColumnCount = 2;
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outerLayoutPanel.Controls.Add(this.imageFlipper, 1, 0);
			this.outerLayoutPanel.Controls.Add(this.leftLayoutPanel, 0, 0);
			this.outerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.outerLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.outerLayoutPanel.Name = "outerLayoutPanel";
			this.outerLayoutPanel.RowCount = 1;
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 264F));
			this.outerLayoutPanel.Size = new System.Drawing.Size(328, 264);
			this.outerLayoutPanel.TabIndex = 0;
			// 
			// imageFlipper
			// 
			this.imageFlipper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageFlipper.Location = new System.Drawing.Point(164, 0);
			this.imageFlipper.Margin = new System.Windows.Forms.Padding(0);
			this.imageFlipper.Name = "imageFlipper";
			this.imageFlipper.Size = new System.Drawing.Size(164, 264);
			this.imageFlipper.TabIndex = 0;
			// 
			// leftLayoutPanel
			// 
			this.leftLayoutPanel.ColumnCount = 1;
			this.leftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.leftLayoutPanel.Controls.Add(this.originalPictureBox, 0, 0);
			this.leftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.leftLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.leftLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.leftLayoutPanel.Name = "leftLayoutPanel";
			this.leftLayoutPanel.RowCount = 2;
			this.leftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.leftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.leftLayoutPanel.Size = new System.Drawing.Size(164, 264);
			this.leftLayoutPanel.TabIndex = 1;
			// 
			// originalPictureBox
			// 
			this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
			this.originalPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.originalPictureBox.Name = "originalPictureBox";
			this.originalPictureBox.Size = new System.Drawing.Size(164, 224);
			this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.originalPictureBox.TabIndex = 0;
			this.originalPictureBox.TabStop = false;
			// 
			// PartTwoControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.outerLayoutPanel);
			this.Name = "PartTwoControl";
			this.Size = new System.Drawing.Size(328, 264);
			this.outerLayoutPanel.ResumeLayout(false);
			this.leftLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
