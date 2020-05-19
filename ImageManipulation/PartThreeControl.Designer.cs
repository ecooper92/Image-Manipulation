/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageManipulation
{
	partial class PartThreeControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
		private System.Windows.Forms.PictureBox originalPictureBox;
		private System.Windows.Forms.PictureBox processedPictureBox;
		
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
			this.outerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.originalPictureBox = new System.Windows.Forms.PictureBox();
			this.processedPictureBox = new System.Windows.Forms.PictureBox();
			this.outerLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// outerLayoutPanel
			// 
			this.outerLayoutPanel.ColumnCount = 2;
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.outerLayoutPanel.Controls.Add(this.originalPictureBox, 0, 0);
			this.outerLayoutPanel.Controls.Add(this.processedPictureBox, 1, 0);
			this.outerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.outerLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.outerLayoutPanel.Name = "outerLayoutPanel";
			this.outerLayoutPanel.RowCount = 2;
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.outerLayoutPanel.Size = new System.Drawing.Size(423, 255);
			this.outerLayoutPanel.TabIndex = 0;
			// 
			// originalPictureBox
			// 
			this.originalPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.originalPictureBox.Location = new System.Drawing.Point(0, 0);
			this.originalPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.originalPictureBox.Name = "originalPictureBox";
			this.originalPictureBox.Size = new System.Drawing.Size(211, 215);
			this.originalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.originalPictureBox.TabIndex = 0;
			this.originalPictureBox.TabStop = false;
			// 
			// processedPictureBox
			// 
			this.processedPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.processedPictureBox.Location = new System.Drawing.Point(211, 0);
			this.processedPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.processedPictureBox.Name = "processedPictureBox";
			this.processedPictureBox.Size = new System.Drawing.Size(212, 215);
			this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.processedPictureBox.TabIndex = 1;
			this.processedPictureBox.TabStop = false;
			// 
			// PartThreeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.outerLayoutPanel);
			this.Name = "PartThreeControl";
			this.Size = new System.Drawing.Size(423, 255);
			this.outerLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
