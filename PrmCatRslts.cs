using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsFndPrmCat;
//using dlgPrmRslts;


namespace clsFndPrmCat
	{
	public partial class dlgPrmRslts : Form
		{
		string strCat = "";
		public dlgPrmRslts()
			{
			InitializeComponent();

			//var buttons = this.Controls.OfType<RadioButton>()
			//										 .FirstOrDefault(n => n.Checked);

			rtbRslts.Clear();
			rtbRslts.SelectionIndent = 10;
			//rtbRslts.Text = results from calculations
			rtbRslts.Text = "Here we are in rtbRslts!!";
			}


		public void OpenDlgRslts(string strName)
			{
			strCat = strName;
			this.Text = this.Text + " " + strCat;
			}

		private void btnOK_Click(object sender, EventArgs e)
			{
			this.Close();
			this.Dispose();
			}
		}
	}
