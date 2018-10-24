namespace clsFndPrmCat
	{
	partial class dlgPrmRslts
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
			this.btnOK = new System.Windows.Forms.Button();
			this.lblLine = new System.Windows.Forms.Label();
			this.rtbRslts = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
			this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(447, 421);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(50, 25);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblLine
			// 
			this.lblLine.AutoSize = true;
			this.lblLine.BackColor = System.Drawing.Color.Cyan;
			this.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.lblLine.Location = new System.Drawing.Point(0, 403);
			this.lblLine.MaximumSize = new System.Drawing.Size(525, 3);
			this.lblLine.MinimumSize = new System.Drawing.Size(525, 3);
			this.lblLine.Name = "lblLine";
			this.lblLine.Size = new System.Drawing.Size(525, 3);
			this.lblLine.TabIndex = 3;
			this.lblLine.Text = "  ";
			// 
			// rtbRslts
			// 
			this.rtbRslts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
			this.rtbRslts.ForeColor = System.Drawing.Color.Cyan;
			this.rtbRslts.Location = new System.Drawing.Point(2, 2);
			this.rtbRslts.Multiline = true;
			this.rtbRslts.Name = "rtbRslts";
			this.rtbRslts.Size = new System.Drawing.Size(505, 400);
			this.rtbRslts.TabIndex = 4;
			this.rtbRslts.TabStop = false;
			// 
			// dlgPrmRslts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
			this.ClientSize = new System.Drawing.Size(509, 461);
			this.Controls.Add(this.rtbRslts);
			this.Controls.Add(this.lblLine);
			this.Controls.Add(this.btnOK);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Cyan;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "dlgPrmRslts";
			this.Text = "Results for Prime Category: ";
			this.ResumeLayout(false);
			this.PerformLayout();

			}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Label lblLine;
		private System.Windows.Forms.RichTextBox rtbRslts;
		}
	}