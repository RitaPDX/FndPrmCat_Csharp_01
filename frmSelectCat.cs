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
	public partial class frmSelectCat : Form
		{
		public static frmSelectCat myForm = new frmSelectCat();
		public static string strMyCat;
		public static string strTitle = strMyCat + " Warning";
		public static string strMsg = "You have selected the " + strMyCat + " category.\n" +
				"This category takes a great deal of time to find the results.\n" +
				"Exercise restraint in choosing the quantity of primes to be found.";

		public frmSelectCat ()
			{
			InitializeComponent();
			}

		// Overload constructor
		public frmSelectCat (string strCat)
			{
			InitializeComponent();
			strMyCat = strCat;
			//myForm.Visible = true;
			myForm.Activate();
			myForm.Enabled = true;
			myForm.Show();
			}

		private void SelectCat_Load (object sender, EventArgs e)
			{
			if ((strMyCat == "Quintuplet") || (strMyCat == "Sextuplet"))
			{ 
			myForm.Text = strTitle;
			myForm.rtbWrng.Text = strMsg;
			}
			else if (strMyCat == "NoRadVal")
				{
				myForm.Text = "User ERROR!";
				myForm.rtbWrng.Text = "You must select a category in order to proceed!";
				}
			}

		private void SelectCat_btnOK_Click (object sender, EventArgs e)
			{
			myForm.Enabled = false;
			myForm.Visible = false;
			myForm.Close();
			//myForm.Dispose();
			}
		}
	}
