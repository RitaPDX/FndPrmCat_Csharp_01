using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clsFndPrmCat
	{
	public partial class frmHlp : Form
		{
		public frmHlp()
			{
			InitializeComponent();
			}

		private void btnOK_Click(object sender, EventArgs e)
			{
			this.Visible = false;
			this.Close();
			this.Dispose();
			}


		}
	}
