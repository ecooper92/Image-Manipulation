namespace ImageManipulation
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage partOnePage;
		private System.Windows.Forms.TabPage partTwoPage;
		private System.Windows.Forms.TabPage partThreePage;
		private System.Windows.Forms.TabPage partFourPage;
		private System.Windows.Forms.TabPage partFivePage;
		private System.Windows.Forms.TableLayoutPanel outerLayoutPanel;
		private System.Windows.Forms.Button generateButton;
		private System.Windows.Forms.TableLayoutPanel outerBottomLayoutPanel;
		private ImageManipulation.PartOneControl partOneControl;
		private ImageManipulation.PartTwoControl partTwoControl;
		private ImageManipulation.PartFourControl partFourControl;
		private ImageManipulation.PartFiveControl partFiveControl;
		private System.Windows.Forms.Button refreshButton;
		private ImageManipulation.PartThreeControl partThreeControl;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		public void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.partOnePage = new System.Windows.Forms.TabPage();
			this.partOneControl = new ImageManipulation.PartOneControl();
			this.partTwoPage = new System.Windows.Forms.TabPage();
			this.partTwoControl = new ImageManipulation.PartTwoControl();
			this.partThreePage = new System.Windows.Forms.TabPage();
			this.partFourPage = new System.Windows.Forms.TabPage();
			this.partFourControl = new ImageManipulation.PartFourControl();
			this.partFivePage = new System.Windows.Forms.TabPage();
			this.partFiveControl = new ImageManipulation.PartFiveControl();
			this.outerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.outerBottomLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.generateButton = new System.Windows.Forms.Button();
			this.refreshButton = new System.Windows.Forms.Button();
			this.partThreeControl = new ImageManipulation.PartThreeControl();
			this.tabControl1.SuspendLayout();
			this.partOnePage.SuspendLayout();
			this.partTwoPage.SuspendLayout();
			this.partThreePage.SuspendLayout();
			this.partFourPage.SuspendLayout();
			this.partFivePage.SuspendLayout();
			this.outerLayoutPanel.SuspendLayout();
			this.outerBottomLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.partOnePage);
			this.tabControl1.Controls.Add(this.partTwoPage);
			this.tabControl1.Controls.Add(this.partThreePage);
			this.tabControl1.Controls.Add(this.partFourPage);
			this.tabControl1.Controls.Add(this.partFivePage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(3, 2);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1007, 404);
			this.tabControl1.TabIndex = 0;
			// 
			// partOnePage
			// 
			this.partOnePage.Controls.Add(this.partOneControl);
			this.partOnePage.Location = new System.Drawing.Point(4, 25);
			this.partOnePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partOnePage.Name = "partOnePage";
			this.partOnePage.Size = new System.Drawing.Size(999, 375);
			this.partOnePage.TabIndex = 0;
			this.partOnePage.Text = "Part 1";
			this.partOnePage.UseVisualStyleBackColor = true;
			// 
			// partOneControl
			// 
			this.partOneControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partOneControl.Image = null;
			this.partOneControl.Location = new System.Drawing.Point(0, 0);
			this.partOneControl.Margin = new System.Windows.Forms.Padding(0);
			this.partOneControl.Name = "partOneControl";
			this.partOneControl.Size = new System.Drawing.Size(999, 375);
			this.partOneControl.TabIndex = 0;
			// 
			// partTwoPage
			// 
			this.partTwoPage.Controls.Add(this.partTwoControl);
			this.partTwoPage.Location = new System.Drawing.Point(4, 25);
			this.partTwoPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partTwoPage.Name = "partTwoPage";
			this.partTwoPage.Size = new System.Drawing.Size(999, 375);
			this.partTwoPage.TabIndex = 1;
			this.partTwoPage.Text = "Part 2";
			this.partTwoPage.UseVisualStyleBackColor = true;
			// 
			// partTwoControl
			// 
			this.partTwoControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partTwoControl.Image = null;
			this.partTwoControl.Location = new System.Drawing.Point(0, 0);
			this.partTwoControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partTwoControl.Name = "partTwoControl";
			this.partTwoControl.Size = new System.Drawing.Size(999, 375);
			this.partTwoControl.TabIndex = 0;
			// 
			// partThreePage
			// 
			this.partThreePage.Controls.Add(this.partThreeControl);
			this.partThreePage.Location = new System.Drawing.Point(4, 25);
			this.partThreePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partThreePage.Name = "partThreePage";
			this.partThreePage.Size = new System.Drawing.Size(999, 375);
			this.partThreePage.TabIndex = 2;
			this.partThreePage.Text = "Part 3";
			this.partThreePage.UseVisualStyleBackColor = true;
			// 
			// partFourPage
			// 
			this.partFourPage.Controls.Add(this.partFourControl);
			this.partFourPage.Location = new System.Drawing.Point(4, 25);
			this.partFourPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partFourPage.Name = "partFourPage";
			this.partFourPage.Size = new System.Drawing.Size(999, 375);
			this.partFourPage.TabIndex = 3;
			this.partFourPage.Text = "Part 4";
			this.partFourPage.UseVisualStyleBackColor = true;
			// 
			// partFourControl
			// 
			this.partFourControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partFourControl.Image = null;
			this.partFourControl.Location = new System.Drawing.Point(0, 0);
			this.partFourControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partFourControl.Name = "partFourControl";
			this.partFourControl.Size = new System.Drawing.Size(999, 375);
			this.partFourControl.TabIndex = 0;
			// 
			// partFivePage
			// 
			this.partFivePage.Controls.Add(this.partFiveControl);
			this.partFivePage.Location = new System.Drawing.Point(4, 25);
			this.partFivePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partFivePage.Name = "partFivePage";
			this.partFivePage.Size = new System.Drawing.Size(999, 375);
			this.partFivePage.TabIndex = 4;
			this.partFivePage.Text = "Part 5";
			this.partFivePage.UseVisualStyleBackColor = true;
			// 
			// partFiveControl
			// 
			this.partFiveControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partFiveControl.Image = null;
			this.partFiveControl.Location = new System.Drawing.Point(0, 0);
			this.partFiveControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.partFiveControl.Name = "partFiveControl";
			this.partFiveControl.Size = new System.Drawing.Size(999, 375);
			this.partFiveControl.TabIndex = 0;
			// 
			// outerLayoutPanel
			// 
			this.outerLayoutPanel.ColumnCount = 1;
			this.outerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.outerLayoutPanel.Controls.Add(this.tabControl1, 0, 0);
			this.outerLayoutPanel.Controls.Add(this.outerBottomLayoutPanel, 0, 1);
			this.outerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.outerLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.outerLayoutPanel.Name = "outerLayoutPanel";
			this.outerLayoutPanel.RowCount = 2;
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.outerLayoutPanel.Size = new System.Drawing.Size(1012, 436);
			this.outerLayoutPanel.TabIndex = 1;
			// 
			// outerBottomLayoutPanel
			// 
			this.outerBottomLayoutPanel.ColumnCount = 3;
			this.outerBottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.outerBottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
			this.outerBottomLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.outerBottomLayoutPanel.Controls.Add(this.generateButton, 1, 0);
			this.outerBottomLayoutPanel.Controls.Add(this.refreshButton, 2, 0);
			this.outerBottomLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outerBottomLayoutPanel.Location = new System.Drawing.Point(0, 406);
			this.outerBottomLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.outerBottomLayoutPanel.Name = "outerBottomLayoutPanel";
			this.outerBottomLayoutPanel.RowCount = 1;
			this.outerBottomLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.outerBottomLayoutPanel.Size = new System.Drawing.Size(1013, 30);
			this.outerBottomLayoutPanel.TabIndex = 1;
			// 
			// generateButton
			// 
			this.generateButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.generateButton.Location = new System.Drawing.Point(851, 2);
			this.generateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(79, 26);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "Generate";
			this.generateButton.UseVisualStyleBackColor = true;
			this.generateButton.Click += new System.EventHandler(this.GenerateButtonClick);
			// 
			// refreshButton
			// 
			this.refreshButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.refreshButton.Location = new System.Drawing.Point(936, 2);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(74, 26);
			this.refreshButton.TabIndex = 1;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.RefreshButtonClick);
			// 
			// partThreeControl
			// 
			this.partThreeControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.partThreeControl.Image = null;
			this.partThreeControl.Location = new System.Drawing.Point(0, 0);
			this.partThreeControl.Margin = new System.Windows.Forms.Padding(0);
			this.partThreeControl.Name = "partThreeControl";
			this.partThreeControl.Size = new System.Drawing.Size(999, 375);
			this.partThreeControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 436);
			this.Controls.Add(this.outerLayoutPanel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "ImageManipulation";
			this.tabControl1.ResumeLayout(false);
			this.partOnePage.ResumeLayout(false);
			this.partTwoPage.ResumeLayout(false);
			this.partThreePage.ResumeLayout(false);
			this.partFourPage.ResumeLayout(false);
			this.partFivePage.ResumeLayout(false);
			this.outerLayoutPanel.ResumeLayout(false);
			this.outerBottomLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
