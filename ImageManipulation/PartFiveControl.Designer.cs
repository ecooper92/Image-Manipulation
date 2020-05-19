/*
 * Created by SharpDevelop.
 * User: J01599
 * Date: 1/21/2015
 * Time: 2:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ImageManipulation
{
	partial class PartFiveControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel layoutPanel;
		private System.Windows.Forms.PictureBox oldPictureBox;
		private System.Windows.Forms.PictureBox newPictureBox;
		private System.Windows.Forms.TableLayoutPanel bottomLayoutPanel;
		private System.Windows.Forms.TrackBar bitsTrackBar;
		private System.Windows.Forms.Label bitsLabel;
		
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
			this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.oldPictureBox = new System.Windows.Forms.PictureBox();
			this.newPictureBox = new System.Windows.Forms.PictureBox();
			this.bottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.bitsTrackBar = new System.Windows.Forms.TrackBar();
			this.bitsLabel = new System.Windows.Forms.Label();
			this.layoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.oldPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).BeginInit();
			this.bottomLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bitsTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutPanel
			// 
			this.layoutPanel.ColumnCount = 2;
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutPanel.Controls.Add(this.oldPictureBox, 0, 0);
			this.layoutPanel.Controls.Add(this.newPictureBox, 1, 0);
			this.layoutPanel.Controls.Add(this.bottomLayoutPanel, 0, 1);
			this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutPanel.Location = new System.Drawing.Point(0, 0);
			this.layoutPanel.Name = "layoutPanel";
			this.layoutPanel.RowCount = 2;
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.layoutPanel.Size = new System.Drawing.Size(467, 302);
			this.layoutPanel.TabIndex = 0;
			// 
			// oldPictureBox
			// 
			this.oldPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.oldPictureBox.Location = new System.Drawing.Point(0, 0);
			this.oldPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.oldPictureBox.Name = "oldPictureBox";
			this.oldPictureBox.Size = new System.Drawing.Size(233, 262);
			this.oldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.oldPictureBox.TabIndex = 0;
			this.oldPictureBox.TabStop = false;
			// 
			// newPictureBox
			// 
			this.newPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newPictureBox.Location = new System.Drawing.Point(233, 0);
			this.newPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.newPictureBox.Name = "newPictureBox";
			this.newPictureBox.Size = new System.Drawing.Size(234, 262);
			this.newPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.newPictureBox.TabIndex = 1;
			this.newPictureBox.TabStop = false;
			// 
			// bottomLayoutPanel
			// 
			this.bottomLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.bottomLayoutPanel.ColumnCount = 2;
			this.layoutPanel.SetColumnSpan(this.bottomLayoutPanel, 2);
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomLayoutPanel.Controls.Add(this.bitsTrackBar, 1, 0);
			this.bottomLayoutPanel.Controls.Add(this.bitsLabel, 0, 0);
			this.bottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomLayoutPanel.Location = new System.Drawing.Point(0, 262);
			this.bottomLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bottomLayoutPanel.Name = "bottomLayoutPanel";
			this.bottomLayoutPanel.RowCount = 1;
			this.bottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomLayoutPanel.Size = new System.Drawing.Size(467, 40);
			this.bottomLayoutPanel.TabIndex = 2;
			// 
			// bitsTrackBar
			// 
			this.bitsTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bitsTrackBar.Location = new System.Drawing.Point(60, 0);
			this.bitsTrackBar.Margin = new System.Windows.Forms.Padding(0);
			this.bitsTrackBar.Maximum = 24;
			this.bitsTrackBar.Minimum = 1;
			this.bitsTrackBar.Name = "bitsTrackBar";
			this.bitsTrackBar.Size = new System.Drawing.Size(407, 40);
			this.bitsTrackBar.TabIndex = 0;
			this.bitsTrackBar.Value = 8;
			this.bitsTrackBar.ValueChanged += new System.EventHandler(this.BitsTrackBarValueChanged);
			// 
			// bitsLabel
			// 
			this.bitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bitsLabel.Location = new System.Drawing.Point(0, 0);
			this.bitsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.bitsLabel.Name = "bitsLabel";
			this.bitsLabel.Size = new System.Drawing.Size(60, 40);
			this.bitsLabel.TabIndex = 1;
			this.bitsLabel.Text = "Bits: 8";
			this.bitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PartFiveControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutPanel);
			this.Name = "PartFiveControl";
			this.Size = new System.Drawing.Size(467, 302);
			this.layoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.oldPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).EndInit();
			this.bottomLayoutPanel.ResumeLayout(false);
			this.bottomLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bitsTrackBar)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
