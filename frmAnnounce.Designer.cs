namespace FndPrmCat
	{
	partial class frmAnnounce
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
			this.editFormUserControl1 = new DevExpress.XtraGrid.Views.Grid.EditFormUserControl();
			this.SuspendLayout();
			// 
			// editFormUserControl1
			// 
			this.editFormUserControl1.Location = new System.Drawing.Point(404, 0);
			this.editFormUserControl1.Name = "editFormUserControl1";
			this.editFormUserControl1.Size = new System.Drawing.Size(928, 395);
			this.editFormUserControl1.TabIndex = 0;
			// 
			// frmAnnounce
			// 
			this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Appearance.BorderColor = System.Drawing.Color.Navy;
			this.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.Appearance.ForeColor = System.Drawing.Color.Navy;
			this.Appearance.Options.UseBackColor = true;
			this.Appearance.Options.UseBorderColor = true;
			this.Appearance.Options.UseFont = true;
			this.Appearance.Options.UseForeColor = true;
			this.Appearance.Options.UseTextOptions = true;
			this.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.editFormUserControl1.SetBoundPropertyName(this, "");
			this.ClientSize = new System.Drawing.Size(480, 257);
			this.Controls.Add(this.editFormUserControl1);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.InactiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAnnounce";
			this.Text = "Warning!";
			this.ResumeLayout(false);

			}

		#endregion

		private DevExpress.XtraGrid.Views.Grid.EditFormUserControl editFormUserControl1;
		}
	}