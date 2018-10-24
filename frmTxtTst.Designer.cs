namespace clsCatRslt
	{
	partial class clsTstTxt
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
			this.rtbRslts = new System.Windows.Forms.RichTextBox();
			this.btnCanx = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rtbRslts
			// 
			this.rtbRslts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rtbRslts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbRslts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbRslts.ForeColor = System.Drawing.Color.Navy;
			this.rtbRslts.Location = new System.Drawing.Point(2, 2);
			this.rtbRslts.Name = "rtbRslts";
			this.rtbRslts.Size = new System.Drawing.Size(505, 210);
			this.rtbRslts.TabIndex = 0;
			this.rtbRslts.Text = "";
			// 
			// btnCanx
			// 
			this.btnCanx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCanx.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
			this.btnCanx.FlatAppearance.BorderSize = 2;
			this.btnCanx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnCanx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnCanx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCanx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCanx.Location = new System.Drawing.Point(449, 222);
			this.btnCanx.Name = "btnCanx";
			this.btnCanx.Size = new System.Drawing.Size(50, 30);
			this.btnCanx.TabIndex = 44;
			this.btnCanx.TabStop = false;
			this.btnCanx.Text = "OK";
			this.btnCanx.UseVisualStyleBackColor = false;
			this.btnCanx.Click += new System.EventHandler(this.btnCanx_Click);
			// 
			// clsCatRslt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(509, 261);
			this.Controls.Add(this.btnCanx);
			this.Controls.Add(this.rtbRslts);
			this.ForeColor = System.Drawing.Color.Navy;
			this.Name = "clsCatRslt";
			this.Text = "clsCatRslt";
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.RichTextBox rtbRslts;
		private System.Windows.Forms.Button btnCanx;
		}
	}