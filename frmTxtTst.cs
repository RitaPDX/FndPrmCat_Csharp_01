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

namespace clsCatRslt
	{
	public partial class clsTstTxt : Form
		{
		public static Form dlgRslts = new Form();
		
		public clsTstTxt()
			{
			InitializeComponent();
			//clsFndPrmCat.frmFndPrmCat.dlgRslts.Activate();
			//clsFndPrmCat.frmFndPrmCat.dlgRslts.Enabled = true;
			//clsFndPrmCat.frmFndPrmCat.dlgRslts.Visible = true;
			}


		//private void btnOK_Cancel(object sender, EventArgs e)
		//	{
		//	//dlgRslts.Enabled = false;
		//	//dlgRslts.Visible = false;
		//	//dlgRslts.Dispose();
		//	}

		private void btnCanx_Click(object sender, EventArgs e)
			{
			clsFndPrmCat.frmFndPrmCat.dlgRslts.Enabled = false;
			clsFndPrmCat.frmFndPrmCat.dlgRslts.Visible = false;
			clsFndPrmCat.frmFndPrmCat.dlgRslts.Dispose();
			}
		}
	}
