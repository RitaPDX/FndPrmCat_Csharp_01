namespace FndPrmCat
	{
	partial class frmScratch
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
			this.btnHlpBiTwin = new System.Windows.Forms.Button();
			this.btnHlpAriProg = new System.Windows.Forms.Button();
			this.radBiTwn = new System.Windows.Forms.RadioButton();
			this.radAriProg = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnHlpBiTwin
			// 
			this.btnHlpBiTwin.BackColor = System.Drawing.Color.DimGray;
			this.btnHlpBiTwin.Enabled = false;
			this.btnHlpBiTwin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnHlpBiTwin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHlpBiTwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHlpBiTwin.ForeColor = System.Drawing.Color.Navy;
			this.btnHlpBiTwin.Location = new System.Drawing.Point(86, 134);
			this.btnHlpBiTwin.Name = "btnHlpBiTwin";
			this.btnHlpBiTwin.Size = new System.Drawing.Size(20, 25);
			this.btnHlpBiTwin.TabIndex = 121;
			this.btnHlpBiTwin.Text = "?";
			this.btnHlpBiTwin.UseVisualStyleBackColor = false;
			// 
			// btnHlpAriProg
			// 
			this.btnHlpAriProg.BackColor = System.Drawing.Color.DimGray;
			this.btnHlpAriProg.Enabled = false;
			this.btnHlpAriProg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnHlpAriProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHlpAriProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHlpAriProg.ForeColor = System.Drawing.Color.Navy;
			this.btnHlpAriProg.Location = new System.Drawing.Point(86, 102);
			this.btnHlpAriProg.Name = "btnHlpAriProg";
			this.btnHlpAriProg.Size = new System.Drawing.Size(20, 25);
			this.btnHlpAriProg.TabIndex = 120;
			this.btnHlpAriProg.Text = "?";
			this.btnHlpAriProg.UseVisualStyleBackColor = false;
			// 
			// radBiTwn
			// 
			this.radBiTwn.AutoSize = true;
			this.radBiTwn.BackColor = System.Drawing.Color.DimGray;
			this.radBiTwn.Enabled = false;
			this.radBiTwn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.radBiTwn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radBiTwn.ForeColor = System.Drawing.Color.Navy;
			this.radBiTwn.Location = new System.Drawing.Point(110, 137);
			this.radBiTwn.Name = "radBiTwn";
			this.radBiTwn.Size = new System.Drawing.Size(89, 17);
			this.radBiTwn.TabIndex = 119;
			this.radBiTwn.TabStop = true;
			this.radBiTwn.Text = "Bi-Twin Chain";
			this.radBiTwn.UseVisualStyleBackColor = false;
			// 
			// radAriProg
			// 
			this.radAriProg.AutoSize = true;
			this.radAriProg.BackColor = System.Drawing.Color.DimGray;
			this.radAriProg.Enabled = false;
			this.radAriProg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.radAriProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.radAriProg.ForeColor = System.Drawing.Color.Navy;
			this.radAriProg.Location = new System.Drawing.Point(110, 106);
			this.radAriProg.Name = "radAriProg";
			this.radAriProg.Size = new System.Drawing.Size(128, 17);
			this.radAriProg.TabIndex = 122;
			this.radAriProg.TabStop = true;
			this.radAriProg.Text = "Arithmetic Progression";
			this.radAriProg.UseVisualStyleBackColor = false;
			// 
			// frmScratch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.radAriProg);
			this.Controls.Add(this.btnHlpBiTwin);
			this.Controls.Add(this.btnHlpAriProg);
			this.Controls.Add(this.radBiTwn);
			this.Name = "frmScratch";
			this.Text = "frmScratch";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnHlpBiTwin;
		private System.Windows.Forms.Button btnHlpAriProg;
		private System.Windows.Forms.RadioButton radBiTwn;
		private System.Windows.Forms.RadioButton radAriProg;
		}
	}