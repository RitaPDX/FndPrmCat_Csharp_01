namespace FndPrmCat
	{
	partial class CatRslts
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
			{
			if (disposing && (components != null))
				{
				components.Dispose();
				}
			base.Dispose(disposing);
			}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
			{
			this.lblLine = new System.Windows.Forms.Label();
			this.btnOK = new CSharpEx.ButtonExx();
			this.rtbRslts = new RichTextBoxEx.RichTextBoxEx();
			this.SuspendLayout();
			// 
			// lblLine
			// 
			this.lblLine.AutoSize = true;
			this.lblLine.BackColor = System.Drawing.Color.Navy;
			this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblLine.ForeColor = System.Drawing.Color.Navy;
			this.lblLine.Location = new System.Drawing.Point(0, 235);
			this.lblLine.MaximumSize = new System.Drawing.Size(650, 3);
			this.lblLine.MinimumSize = new System.Drawing.Size(640, 3);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(640, 3);
			this.lblLine.TabIndex = 6;
			this.lblLine.Text = "  ";
			// 
			// btnOK
			// 
			this.btnOK.AnimateSpeed = 12;
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.btnOK.BackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorEndHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorEndPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorEndUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btnOK.BackColorStart = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorStartHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorStartPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackColorStartUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOK.BorderColor = System.Drawing.Color.Navy;
			this.btnOK.BorderColorHover = System.Drawing.Color.Navy;
			this.btnOK.BorderColorPress = System.Drawing.Color.Navy;
			this.btnOK.BorderColorUnEnable = System.Drawing.Color.Navy;
			this.btnOK.BorderRadius.LeftBottom = 10;
			this.btnOK.BorderRadius.LeftTop = 10;
			this.btnOK.BorderRadius.RightBottom = 10;
			this.btnOK.BorderRadius.RightTop = 10;
			this.btnOK.BottomHighlightHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BottomHighlightNormal = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.BottomHighlightPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOK.ButtonStyle = CSharpEx.ButtonExx.ButtonStyleEnum.Customer;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.Navy;
			this.btnOK.ForeColorUnEnable = System.Drawing.Color.Gray;
			this.btnOK.ImageHover = null;
			this.btnOK.ImageNormal = null;
			this.btnOK.ImagePress = null;
			this.btnOK.ImageTextPosition = CSharpEx.ButtonExx.ImageTextPositionEnum.None;
			this.btnOK.ImageTextScale = 50;
			this.btnOK.InnerBorderColor = System.Drawing.Color.Navy;
			this.btnOK.InnerBorderColorHover = System.Drawing.Color.Navy;
			this.btnOK.InnerBorderColorPress = System.Drawing.Color.Navy;
			this.btnOK.InnerBorderColorUnEnable = System.Drawing.Color.Navy;
			this.btnOK.Location = new System.Drawing.Point(565, 247);
			this.btnOK.Margin = new System.Windows.Forms.Padding(5);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(60, 30);
			this.btnOK.TabIndex = 43;
			this.btnOK.Text = "OK";
			this.btnOK.TopHighlightHover = System.Drawing.Color.Transparent;
			this.btnOK.TopHighlightNormal = System.Drawing.Color.Transparent;
			this.btnOK.TopHighlightPress = System.Drawing.Color.Transparent;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// rtbRslts
			// 
			this.rtbRslts.AcceptsTab = false;
			this.rtbRslts.AutoWordSelection = true;
			this.rtbRslts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbRslts.DetectURLs = true;
			this.rtbRslts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbRslts.ForeColor = System.Drawing.Color.Navy;
			this.rtbRslts.Location = new System.Drawing.Point(3, 2);
			this.rtbRslts.Name = "rtbRslts";
			this.rtbRslts.ReadOnly = false;
			// 
			// 
			// 
			this.rtbRslts.RichTextBox.AutoWordSelection = true;
			this.rtbRslts.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rtbRslts.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbRslts.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbRslts.RichTextBox.Location = new System.Drawing.Point(0, 0);
			this.rtbRslts.RichTextBox.Name = "rtb1";
			this.rtbRslts.RichTextBox.Size = new System.Drawing.Size(625, 223);
			this.rtbRslts.RichTextBox.TabIndex = 1;
			this.rtbRslts.ShowBold = true;
			this.rtbRslts.ShowCenterJustify = true;
			this.rtbRslts.ShowColors = true;
			this.rtbRslts.ShowCopy = true;
			this.rtbRslts.ShowCut = true;
			this.rtbRslts.ShowFont = true;
			this.rtbRslts.ShowFontSize = true;
			this.rtbRslts.ShowItalic = true;
			this.rtbRslts.ShowLeftJustify = true;
			this.rtbRslts.ShowOpen = true;
			this.rtbRslts.ShowPaste = true;
			this.rtbRslts.ShowRedo = true;
			this.rtbRslts.ShowRightJustify = true;
			this.rtbRslts.ShowSave = true;
			this.rtbRslts.ShowStamp = true;
			this.rtbRslts.ShowStrikeout = true;
			this.rtbRslts.ShowToolBarText = false;
			this.rtbRslts.ShowUnderline = true;
			this.rtbRslts.ShowUndo = true;
			this.rtbRslts.Size = new System.Drawing.Size(627, 225);
			this.rtbRslts.StampAction = RichTextBoxEx.StampActions.EditedBy;
			this.rtbRslts.StampColor = System.Drawing.Color.Blue;
			this.rtbRslts.TabIndex = 44;
			// 
			// 
			// 
			this.rtbRslts.Toolbar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.rtbRslts.Toolbar.ButtonSize = new System.Drawing.Size(16, 16);
			this.rtbRslts.Toolbar.Divider = false;
			this.rtbRslts.Toolbar.DropDownArrows = true;
			this.rtbRslts.Toolbar.Enabled = false;
			this.rtbRslts.Toolbar.Location = new System.Drawing.Point(0, 0);
			this.rtbRslts.Toolbar.Name = "tb1";
			this.rtbRslts.Toolbar.ShowToolTips = true;
			this.rtbRslts.Toolbar.Size = new System.Drawing.Size(503, 20);
			this.rtbRslts.Toolbar.TabIndex = 0;
			this.rtbRslts.Toolbar.Visible = false;
			// 
			// CatRslts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(634, 286);
			this.Controls.Add(this.rtbRslts);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblLine);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Cyan;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CatRslts";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Primes of Category: ";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Label lblLine;
		private CSharpEx.ButtonExx btnOK;
		public RichTextBoxEx.RichTextBoxEx rtbRslts;
		}
	}