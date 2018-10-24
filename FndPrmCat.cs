using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FndPrmCat;
using InfoBox;

namespace FndPrmCat
	{
	public partial class frmFndPrmCat : Form
		{

		//	Declare some global variables
		public int intCnt;
		public int intInit;
		public string radTxt;
		public string strCntrlName;
		public static List<string> lstRslt = new List<string>();
		public static FndPrmCat.CatRslts dlgRslts = new FndPrmCat.CatRslts();
		public static clsCalcPrimes CalcPrms = new clsCalcPrimes();
		public static Form frmMine = new frmFndPrmCat();

		public frmFndPrmCat()
			{
			InitializeComponent();
			}

		private void radQuint_Click (object sender, EventArgs e)
			{
			string strMyCat = "Quintuplet";
			string strTitle = strMyCat + " Warning";
			string message ="You have selected the " + strMyCat + " category.\n" +
				"This category takes a great deal of time to find the results.\n" +
				"Exercise restraint in choosing the quantity of primes to be found.";

			var btnButtons = MessageBoxButtons.OK;
			var result = MessageBox.Show(message, strTitle, btnButtons, MessageBoxIcon.Warning);
			}

		private void radSext_Click (object sender, EventArgs e)
			{
			string strMyCat = "Sextuplet";
			string strTitle = strMyCat + " Warning";
			string message ="You have selected the " + strMyCat + " category.\n" +
				"This category takes a great deal of time to find the results.\n" +
				"Exercise restraint in choosing the quantity of primes to be found.";
			
			var btnButtons = MessageBoxButtons.OK;
			var result = MessageBox.Show(message, strTitle, btnButtons, MessageBoxIcon.Warning);
			}

		public static void Main (string[] args)
			{
			Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			 Application.Run(frmMine);
			}

		private void frmFndPrmCat_Load(object sender, EventArgs e)
			{
			frmMine.Activate();
			frmMine.Enabled = true;
			frmMine.Visible = true;
			frmMine.Show();
			}

		private string strGetRadVal()
			{
			RadioButton selectedButton = new RadioButton();
			selectedButton = grpCat.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

			if (selectedButton == null)
				{
				string strTitle = "User Error!";
				string message = "You must select a category of Prime Number in order to proceed";

				var btnButtons = MessageBoxButtons.OK;
				var result = MessageBox.Show(message, strTitle, btnButtons, MessageBoxIcon.Error);
				radTxt = "ERROR";
				return (radTxt);
				}
			else
				{
				radTxt = selectedButton.Text;
				}
			return (radTxt);
			}

		private int intGetInitVal()
			{
			intInit = (int)this.updInit.Value;
			return (intInit);
			}

		private int intGetCntVal()
			{
			intCnt = (int)this.updCnt.Value;
			return (intCnt);
			}

		// nameList = productList.Select(p => p.ToString()).ToList();

		public void dlgOpnDlg(List<string> lstRslt, string strRadTxt)
			{
			dlgRslts.strCat = radTxt;
			dlgRslts.rtbRslts.RichTextBox.Text = strGetLst2Str(lstRslt);
			dlgRslts.OpenDlgRslts(lstRslt);
			dlgRslts.ShowDialog();
			}

		public string strGetLst2Str(List<string> lstIn)
			{
			// Convert an array of strings to one string.
			intCnt = lstIn.Count();
			string[] strArrOut = new string[intCnt];
			for (int i = 0; i < intCnt; i++)
				{
				 strArrOut[i] = lstIn[i];       //.ToArray();
				}
			string strOut = string.Join("", strArrOut);
			return (strOut);
			}

		private void btnOK_Click(object sender, EventArgs e)
			{
			radTxt = strGetRadVal();

			if (radTxt == "ERROR")
				{
				return;
				}
			else
				{
				intCnt = intGetCntVal();
				intInit = intGetInitVal();
				int intLngth = lstRslt.Count();

				FndPrmCat.clsCalcPrimes MyCalc = new FndPrmCat.clsCalcPrimes(intCnt, intInit, radTxt);

				// TODO Get results text and pass it to DlgRslts via OpenDlgRslts
				// Results text comes from clsCalcPrimes

				dlgOpnDlg(lstRslt, radTxt);

				lstRslt.Clear();
				updInit.Value = (decimal)2;
				updCnt.Value = (decimal)2;
				}
			}

		private void btnCanx_Click(object sender, EventArgs e)
			{
			this.Enabled = false;
			this.Dispose();
			this.Visible = false;
			}

		private void btnHlpTwin_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Twin");
			}

		private void btnHlpSexy_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Sexy");
			}

		private void btnHlpTrip_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Trip");
			}

		private void btnHlpQuad_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Quad");
			}

		private void btnHlpQuin_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Quin");
			}

		private void btnHlpSext_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Sext");
			}

		private void btnHlpCous_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Cous");
			}

		private void btnHlpSoph_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Soph");
			}

		private void btnHlpCunn_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Cunn");
			}

		private void btnHlpSafe_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Safe");
			}

		private void btnHlpBaln_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Baln");
			}

		private void btnHlpNorm_Click(object sender, EventArgs e)
			{
			FndPrmCat.frmCatHlp frmMyHlp = new FndPrmCat.frmCatHlp("Norm");
			}
		}
	}


