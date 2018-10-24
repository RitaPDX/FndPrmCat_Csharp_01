namespace FndPrmCat
	{
	partial class frmSelectCat
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
			this.btnOK = new System.Windows.Forms.Button();
			this.rtbWrng = new System.Windows.Forms.RichTextBox();
			this.lblLn = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Navy;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.ForeColor = System.Drawing.Color.Cyan;
			this.btnOK.Location = new System.Drawing.Point(437, 145);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(71, 38);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.SelectCat_btnOK_Click);
			// 
			// rtbWrng
			// 
			this.rtbWrng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rtbWrng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbWrng.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbWrng.ForeColor = System.Drawing.Color.Navy;
			this.rtbWrng.Location = new System.Drawing.Point(6, 6);
			this.rtbWrng.Name = "rtbWrng";
			this.rtbWrng.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.rtbWrng.Size = new System.Drawing.Size(502, 120);
			this.rtbWrng.TabIndex = 1;
			this.rtbWrng.TabStop = false;
			this.rtbWrng.Text = "";
			// 
			// lblLn
			// 
			this.lblLn.AutoSize = true;
			this.lblLn.BackColor = System.Drawing.Color.Navy;
			this.lblLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLn.Location = new System.Drawing.Point(0, 135);
			this.lblLn.MaximumSize = new System.Drawing.Size(530, 2);
			this.lblLn.MinimumSize = new System.Drawing.Size(530, 2);
			this.lblLn.Name = "lblLn";
			this.lblLn.Size = new System.Drawing.Size(530, 2);
			this.lblLn.TabIndex = 2;
			this.lblLn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmSelectCat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(514, 190);
			this.Controls.Add(this.lblLn);
			this.Controls.Add(this.rtbWrng);
			this.Controls.Add(this.btnOK);
			this.ForeColor = System.Drawing.Color.Navy;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSelectCat";
			this.Text = "Warning!";
			this.Load += new System.EventHandler(this.SelectCat_Load);
			this.Enter += new System.EventHandler(this.SelectCat_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblLn;
		public System.Windows.Forms.RichTextBox rtbWrng;
		}
	}