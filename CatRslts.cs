using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FndPrmCat;

namespace FndPrmCat
	{
	public partial class CatRslts : Form
		{

		public string strCat = ""; 

		public CatRslts()
			{
			InitializeComponent();
			}


		public void OpenDlgRslts(List<string> lstRslt)
			{
			int i = 0;
			int intLngth = lstRslt.Count();
			rtbRslts.RichTextBox.SelectionIndent = 10;
			this.Text = this.Text + " " + strCat;
			}


		private void btnOK_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmFndPrmCat.lstRslt.Clear();
			rtbRslts.RichTextBox.Text = "";
			rtbRslts.RichTextBox.Clear();
			
			this.Visible = false;
			this.Close();
			FndPrmCat.frmFndPrmCat frmMine = new FndPrmCat.frmFndPrmCat();
			frmMine.Refresh();
			}
		}
	}
