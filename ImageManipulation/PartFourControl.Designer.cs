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
	partial class PartFourControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel layoutPanel;
		private System.Windows.Forms.PictureBox oldPictureBox;
		private System.Windows.Forms.PictureBox newPictureBox;
		
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
			this.redTrackBar = new System.Windows.Forms.TrackBar();
			this.greenTrackBar = new System.Windows.Forms.TrackBar();
			this.blueTrackBar = new System.Windows.Forms.TrackBar();
			this.redBitsLabel = new System.Windows.Forms.Label();
			this.greenBitsLabel = new System.Windows.Forms.Label();
			this.blueBitsLabel = new System.Windows.Forms.Label();
			this.layoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.oldPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).BeginInit();
			this.bottomLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).BeginInit();
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
			this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.layoutPanel.Name = "layoutPanel";
			this.layoutPanel.RowCount = 2;
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.layoutPanel.Size = new System.Drawing.Size(733, 327);
			this.layoutPanel.TabIndex = 0;
			// 
			// oldPictureBox
			// 
			this.oldPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.oldPictureBox.Location = new System.Drawing.Point(0, 0);
			this.oldPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.oldPictureBox.Name = "oldPictureBox";
			this.oldPictureBox.Size = new System.Drawing.Size(366, 287);
			this.oldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.oldPictureBox.TabIndex = 0;
			this.oldPictureBox.TabStop = false;
			// 
			// newPictureBox
			// 
			this.newPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newPictureBox.Location = new System.Drawing.Point(366, 0);
			this.newPictureBox.Margin = new System.Windows.Forms.Padding(0);
			this.newPictureBox.Name = "newPictureBox";
			this.newPictureBox.Size = new System.Drawing.Size(367, 287);
			this.newPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.newPictureBox.TabIndex = 1;
			this.newPictureBox.TabStop = false;
			// 
			// bottomLayoutPanel
			// 
			this.bottomLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.bottomLayoutPanel.ColumnCount = 6;
			this.layoutPanel.SetColumnSpan(this.bottomLayoutPanel, 2);
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.bottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.bottomLayoutPanel.Controls.Add(this.redTrackBar, 1, 0);
			this.bottomLayoutPanel.Controls.Add(this.greenTrackBar, 3, 0);
			this.bottomLayoutPanel.Controls.Add(this.blueTrackBar, 5, 0);
			this.bottomLayoutPanel.Controls.Add(this.redBitsLabel, 0, 0);
			this.bottomLayoutPanel.Controls.Add(this.greenBitsLabel, 2, 0);
			this.bottomLayoutPanel.Controls.Add(this.blueBitsLabel, 4, 0);
			this.bottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bottomLayoutPanel.Location = new System.Drawing.Point(0, 287);
			this.bottomLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.bottomLayoutPanel.Name = "bottomLayoutPanel";
			this.bottomLayoutPanel.RowCount = 1;
			this.bottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.bottomLayoutPanel.Size = new System.Drawing.Size(733, 40);
			this.bottomLayoutPanel.TabIndex = 2;
			// 
			// redTrackBar
			// 
			this.redTrackBar.BackColor = System.Drawing.SystemColors.Control;
			this.redTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.redTrackBar.Location = new System.Drawing.Point(60, 0);
			this.redTrackBar.Margin = new System.Windows.Forms.Padding(0);
			this.redTrackBar.Maximum = 8;
			this.redTrackBar.Name = "redTrackBar";
			this.redTrackBar.Size = new System.Drawing.Size(179, 40);
			this.redTrackBar.TabIndex = 0;
			this.redTrackBar.Value = 4;
			this.redTrackBar.ValueChanged += new System.EventHandler(this.RedTrackBarValueChanged);
			// 
			// greenTrackBar
			// 
			this.greenTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.greenTrackBar.Location = new System.Drawing.Point(314, 0);
			this.greenTrackBar.Margin = new System.Windows.Forms.Padding(0);
			this.greenTrackBar.Maximum = 8;
			this.greenTrackBar.Name = "greenTrackBar";
			this.greenTrackBar.Size = new System.Drawing.Size(179, 40);
			this.greenTrackBar.TabIndex = 1;
			this.greenTrackBar.Value = 2;
			this.greenTrackBar.ValueChanged += new System.EventHandler(this.GreenTrackBarValueChanged);
			// 
			// blueTrackBar
			// 
			this.blueTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.blueTrackBar.Location = new System.Drawing.Point(553, 0);
			this.blueTrackBar.Margin = new System.Windows.Forms.Padding(0);
			this.blueTrackBar.Maximum = 8;
			this.blueTrackBar.Name = "blueTrackBar";
			this.blueTrackBar.Size = new System.Drawing.Size(180, 40);
			this.blueTrackBar.TabIndex = 2;
			this.blueTrackBar.Value = 2;
			this.blueTrackBar.ValueChanged += new System.EventHandler(this.BlueTrackBarValueChanged);
			// 
			// redBitsLabel
			// 
			this.redBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.redBitsLabel.Location = new System.Drawing.Point(0, 0);
			this.redBitsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.redBitsLabel.Name = "redBitsLabel";
			this.redBitsLabel.Size = new System.Drawing.Size(60, 40);
			this.redBitsLabel.TabIndex = 3;
			this.redBitsLabel.Text = "Red: 4";
			this.redBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// greenBitsLabel
			// 
			this.greenBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.greenBitsLabel.Location = new System.Drawing.Point(242, 0);
			this.greenBitsLabel.Name = "greenBitsLabel";
			this.greenBitsLabel.Size = new System.Drawing.Size(69, 40);
			this.greenBitsLabel.TabIndex = 4;
			this.greenBitsLabel.Text = "Green: 2";
			this.greenBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// blueBitsLabel
			// 
			this.blueBitsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.blueBitsLabel.Location = new System.Drawing.Point(496, 0);
			this.blueBitsLabel.Name = "blueBitsLabel";
			this.blueBitsLabel.Size = new System.Drawing.Size(54, 40);
			this.blueBitsLabel.TabIndex = 5;
			this.blueBitsLabel.Text = "Blue: 2";
			this.blueBitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PartFourControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layoutPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "PartFourControl";
			this.Size = new System.Drawing.Size(733, 327);
			this.layoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.oldPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).EndInit();
			this.bottomLayoutPanel.ResumeLayout(false);
			this.bottomLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.redTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greenTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blueTrackBar)).EndInit();
			this.ResumeLayout(false);

		}

        private System.Windows.Forms.TableLayoutPanel bottomLayoutPanel;
        private System.Windows.Forms.TrackBar redTrackBar;
        private System.Windows.Forms.TrackBar greenTrackBar;
        private System.Windows.Forms.TrackBar blueTrackBar;
        private System.Windows.Forms.Label redBitsLabel;
        private System.Windows.Forms.Label greenBitsLabel;
        private System.Windows.Forms.Label blueBitsLabel;
	}
}
