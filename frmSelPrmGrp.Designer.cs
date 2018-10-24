namespace FndPrmCat
	{
	partial class frmSelPrmCat
		{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
		private void InitializeComponent ()
			{
			this.btnCanx = new CSharpEx.ButtonExx();
			this.SuspendLayout();
			// 
			// btnCanx
			// 
			this.btnCanx.AnimateSpeed = 12;
			this.btnCanx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
			this.btnCanx.BackColorEnd = System.Drawing.Color.Navy;
			this.btnCanx.BackColorEndHover = System.Drawing.Color.DarkOrchid;
			this.btnCanx.BackColorEndPress = System.Drawing.Color.SkyBlue;
			this.btnCanx.BackColorEndUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCanx.BackColorMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.btnCanx.BackColorStart = System.Drawing.Color.Navy;
			this.btnCanx.BackColorStartHover = System.Drawing.Color.DarkOrchid;
			this.btnCanx.BackColorStartPress = System.Drawing.Color.SkyBlue;
			this.btnCanx.BackColorStartUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnCanx.BorderColor = System.Drawing.Color.Cyan;
			this.btnCanx.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(126)))), ((int)(((byte)(174)))));
			this.btnCanx.BorderColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(175)))), ((int)(((byte)(188)))));
			this.btnCanx.BorderColorUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(214)))), ((int)(((byte)(221)))));
			this.btnCanx.BorderRadius.LeftBottom = 5;
			this.btnCanx.BorderRadius.LeftTop = 5;
			this.btnCanx.BorderRadius.RightBottom = 5;
			this.btnCanx.BorderRadius.RightTop = 5;
			this.btnCanx.BottomHighlightHover = System.Drawing.Color.Transparent;
			this.btnCanx.BottomHighlightNormal = System.Drawing.Color.Transparent;
			this.btnCanx.BottomHighlightPress = System.Drawing.Color.Transparent;
			this.btnCanx.ButtonStyle = CSharpEx.ButtonExx.ButtonStyleEnum.QQ;
			this.btnCanx.ForeColor = System.Drawing.Color.Cyan;
			this.btnCanx.ForeColorUnEnable = System.Drawing.Color.Gray;
			this.btnCanx.ImageHover = null;
			this.btnCanx.ImageNormal = null;
			this.btnCanx.ImagePress = null;
			this.btnCanx.ImageTextPosition = CSharpEx.ButtonExx.ImageTextPositionEnum.None;
			this.btnCanx.ImageTextScale = 50;
			this.btnCanx.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
			this.btnCanx.InnerBorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
			this.btnCanx.InnerBorderColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
			this.btnCanx.InnerBorderColorUnEnable = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
			this.btnCanx.Location = new System.Drawing.Point(357, 178);
			this.btnCanx.Name = "btnCanx";
			this.btnCanx.Size = new System.Drawing.Size(50, 25);
			this.btnCanx.TabIndex = 0;
			this.btnCanx.Text = "Exit";
			this.btnCanx.TopHighlightHover = System.Drawing.Color.Transparent;
			this.btnCanx.TopHighlightNormal = System.Drawing.Color.Transparent;
			this.btnCanx.TopHighlightPress = System.Drawing.Color.Transparent;
			// 
			// frmSelPrmGrp
			// 
			this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Appearance.ForeColor = System.Drawing.Color.Navy;
			this.Appearance.Options.UseBackColor = true;
			this.Appearance.Options.UseFont = true;
			this.Appearance.Options.UseForeColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 211);
			this.Controls.Add(this.btnCanx);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.LookAndFeel.SkinName = "The Bezier";
			this.LookAndFeel.UseWindowsXPTheme = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelPrmGrp";
			this.Text = "Choose Prime Number Group";
			this.ResumeLayout(false);

			}

		#endregion

		private CSharpEx.ButtonExx btnCanx;
		}
	}