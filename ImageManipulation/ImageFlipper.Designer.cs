/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/22/2015
 * Time: 8:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageManipulation
{
	partial class ImageFlipper
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
		private System.Windows.Forms.TableLayoutPanel controlLayoutPanel;
		private System.Windows.Forms.Button prevButton;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.PictureBox pictureBox;
		
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
			this.controlLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.prevButton = new System.Windows.Forms.Button();
			this.nextButton = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.outerLayoutPanel.SuspendLayout();
			this.controlLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// outerLayoutPanel
			// 
			this.outerLayoutPanel.ColumnCount = 1;
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerLayoutPanel.Controls.Add(this.controlLayoutPanel, 0, 1);
			this.outerLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
			this.outerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.outerLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.outerLayoutPanel.Name = "outerLayoutPanel";
			this.outerLayoutPanel.RowCount = 2;
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.outerLayoutPanel.Size = new System.Drawing.Size(337, 315);
			this.outerLayoutPanel.TabIndex = 0;
			// 
			// controlLayoutPanel
			// 
			this.controlLayoutPanel.ColumnCount = 2;
			this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.controlLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.controlLayoutPanel.Controls.Add(this.prevButton, 0, 0);
			this.controlLayoutPanel.Controls.Add(this.nextButton, 1, 0);
			this.controlLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.controlLayoutPanel.Location = new System.Drawing.Point(0, 275);
			this.controlLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.controlLayoutPanel.Name = "controlLayoutPanel";
			this.controlLayoutPanel.RowCount = 1;
			this.controlLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.controlLayoutPanel.Size = new System.Drawing.Size(337, 40);
			this.controlLayoutPanel.TabIndex = 0;
			// 
			// prevButton
			// 
			this.prevButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.prevButton.Location = new System.Drawing.Point(105, 5);
			this.prevButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.prevButton.Name = "prevButton";
			this.prevButton.Size = new System.Drawing.Size(60, 30);
			this.prevButton.TabIndex = 0;
			this.prevButton.Text = "<";
			this.prevButton.UseVisualStyleBackColor = true;
			this.prevButton.Click += new System.EventHandler(this.PrevButtonClick);
			// 
			// nextButton
			// 
			this.nextButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.nextButton.Location = new System.Drawing.Point(171, 5);
			this.nextButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(60, 30);
			this.nextButton.TabIndex = 1;
			this.nextButton.Text = ">";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.NextButtonClick);
			// 
			// pictureBox
			// 
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(337, 275);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// ImageFlipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.outerLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ImageFlipper";
			this.Size = new System.Drawing.Size(337, 315);
			this.outerLayoutPanel.ResumeLayout(false);
			this.controlLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
