/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 10:45 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageManipulation
{
	partial class PartOneControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel partOneLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox originalPictureBox;
		private ImageManipulation.ImageFlipper imageFlipper;
		
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
		/// </summary>
		private void InitializeComponent()
		{
			this.partOneLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.imageFlipper = new ImageManipulation.ImageFlipper();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.originalPictureBox = new System.Windows.Forms.PictureBox();
			this.partOneLayoutPanel.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// partOneLayoutPanel
			// 
			this.partOneLayoutPanel.ColumnCount = 2;
			this.partOneLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.partOneLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.partOneLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.partOneLayoutPanel.Controls.Add(this.imageFlipper, 1, 0);
			this.partOneLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.partOneLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partOneLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.partOneLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.partOneLayoutPanel.Name = "partOneLayoutPanel";
			this.partOneLayoutPanel.RowCount = 1;
			this.partOneLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.partOneLayoutPanel.Size = new System.Drawing.Size(458, 150);
			this.partOneLayoutPanel.TabIndex = 2;
			// 
			// imageFlipper
			// 
			this.imageFlipper.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imageFlipper.Location = new System.Drawing.Point(229, 0);
			this.imageFlipper.Margin = new System.Windows.Forms.Padding(0);
			this.imageFlipper.Name = "imageFlipper";
			this.imageFlipper.Size = new System.Drawing.Size(229, 150);
			this.imageFlipper.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 150);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// originalPictureBox
			// 
			this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
			this.originalPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.originalPictureBox.Name = "originalPictureBox";
			this.originalPictureBox.Size = new System.Drawing.Size(229, 110);
			this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.originalPictureBox.TabIndex = 0;
			this.originalPictureBox.TabStop = false;
			// 
			// PartOneControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.partOneLayoutPanel);
			this.Name = "PartOneControl";
			this.Size = new System.Drawing.Size(458, 150);
			this.partOneLayoutPanel.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
