using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FndPrmCat
	{
	public partial class frmCatHlp : Form
		{

		public string strCatHlp;
		public string Hlp;
		public string radNm;

		public frmCatHlp(string strCatHlp)
			{
			InitializeComponent();
			strCatHlpInit(strCatHlp);
			this.Activate();
			ShowHlp(Hlp, radNm);
			}

		private void strCatHlpInit(string strCatHlp)
			{
			switch (strCatHlp)
				{
				case "Twin":
					radNm = "Twin";
					Hlp = " Twin Primes: \n" +
					" A pair of prime numbers in the form \n" +
					" (p, p + 2)  Example (3, 5), (11, 13)";
					break;

				case "Trip":
					radNm = "Triplet";
					Hlp = " Triplet Primes: \n" +
					" Three prime numbers in the form \n" +
					" (p, p + 2, p + 6) or (p, p + 4, p + 6)  \n" +
					" Example (3, 5, 7), (5, 7, 11), (7, 11, 13)";
					break;

				case "Quad":
					radNm = "Quadruplet";
					Hlp = " Quadruplet Primes: \n" +
					" A prime constellation of four successive primes \n" +
					" with minimal distance (p, p + 2, p + 6, p + 8). \n" +
					" Examples: (5,  7,   11, 13), (11, 13, 17, 19) \n" +
					" With the exception of the two examples shown above,\n" +
					" a prime quadruple must be of the form: \n" +
					" (30n+11, 30n+13, 30n+17, 30n+19).\n" +
					" A few values of n which give prime quadruples\n" +
					" are n = 0, 3, 6, 27, 49, 62, 69, 108, 115, ...";
					break;

				case "Quin":
					radNm = "Quintuplet";
					Hlp = " Quintuplet Primes:\n" +
					" A prime constellation of five successive primes \n" +
					" with minimal distance  (p, p + 2, p + 6, p + 8, p + 12)\n" +
					" \t\t\t\t\tOR\n" +
					" \t\t\t  (p - 4, p, p + 2, p + 6, p + 8)\n" +
					" Examples: \n" +
					" {5, 7, 11, 13, 17}, {11, 13, 17, 19, 23},\n" +
					" {101, 103, 107, 109, 113}, {1481, 1483, 1487, 1489, 1493}\n\n" +
					" NOTE: Exercise caution when entering the number of\n" +
					" Quintuplet Primes you wish to find.\n" +
					" This is an extremely time consuming function!";
					break;

				case "Sext":
					radNm = "Sextuplet";
					Hlp = " Sextuplet Primes:\n" +
					" A prime constellation of five successive primes \n" +
					" with minimal distance (p - 4, p, p + 2, p + 6, p + 8, p + 12)\n" +
					" Examples: \n" +
					" {7, 11, 13, 17, 19, 23}, {97, 101, 103, 107, 109, 113},\n" +
					" {16057, 16061, 16063, 16067, 16069, 16073},\n\n" +
					" NOTE: Exercise caution when entering the number of\n" +
					" Sextuplet Primes you wish to find.\n" +
					" This is an extremely time consuming function!";
					break;

				case "Cous":
					radNm = "Cousin";
					Hlp = " Cousin Primes:\n" +
						" Pairs of primes of the form (p, p + 4) \n" +
						" Examples: \n" +
						" (3, 7), (7, 11), (13, 17), (19, 23), (37, 41), (43, 47), (67, 71), ... ";
					break;

				case "Sexy":
					radNm = "Sexy";
					Hlp = " Sexy Primes:\n" +
						" Pairs of primes of the form (p, p+6),\n" +
						" so-named since \" sex\"  is the Latin word for \" six.\" \n" +
						" The first few sexy prime pairs are:\n" +
						" (5, 11), (7, 13), (11, 17), (13, 19), (17, 23), (23, 29),\n" +
						" (31, 37), (37, 43), (41, 47), (47, 53), ...";
					break;

				case "Soph":
					radNm = "Sophie Germain";
					Hlp = " Sophie Germain Primes:\n" +
					" A prime p is said to be a Sophie Germain prime if\n" + " " +
					" both p and 2p+1, the form (p, 2p+1), are prime. \n" +
					" The first few Sophie Germain primes are: \n" +
					" 2 and 5, 3 and 7, 5 and 11, 11 and 23, 29 and 59, ...\n" +
					" Example: 2, (2 * 2) + 1 = 5 are both primes and\n" +
					" 11, (11 * 2) + 1 = 23 are both primes.";
					break;

				case "Cunn":
					radNm = "Cunningham Chain";
					Hlp = " Cunningham Chain:\n" +
					" Prime numbers of the form (p, 2p ± 1)\n" +
					" are members of a Cunningham Chain. Oviously, the form\n" +
					" (p, 2p + 1) is identical to the Sophie Germaine primes.\n" +
					" They form a Cunningham Chain of the first kind. Primes \n" +
					" of the form (p, 2p -1) are members of a Cunningham\n" +
					" Chain of the second kind. \n" +
					" Examples of Cunningham Chain primes of the second kind:\n" +
					" 2, 3, 5, 7, 19, ...";
					break;

				case "Safe":
					radNm = "Safe";
					Hlp = " Safe Primes:\n" +
					" A safe prime of the form (p, (p - 1)/2).\n" +
					" Given a prime number, p, if (p - 1)/2 is also a prime,\n" +
					" then p is a safe prime. Examples:\n" +
					" 5, (5-1)/2 = 2 is prime\n" +
					" 7, (7-1)/2 = 3 is prime\n" +
					" 23, (23 - 1) = 11 is prime.";
					break;

				case "Baln":
					radNm = "Balanced Primes";
					Hlp = " Balanced Primes:\n" +
					" Primes which are the mean of the next prime number and the\n" +
					" previous prime number. This can be expressed as\n" +
					" p_n = {{p_{n - 1} + p_{n + 1}} / 2}, where {{p_n}} is the nth\n" +
					" prime number and {{p_{n - 1}}} and {{p_{n + 1}}} are the previous\n" +
					" prime number and the next prime number, respectively. 5 is the\n" +
					" first balanced prime, as 3 + 7 / 2 = 5. In theory, in order to be\n" +
					" a balanced prime, the difference between the nth prime number\n" +
					" and the n+1th prime number can be any even number, as long as it\n" +
					" is the same as the gap between the nth and the n-1th. Most of said\n" +
					" even numbers are multiples of three, as a result of the pigeonhole\n" +
					" principle. If the difference is not a multiple of three, one of the\n" +
					" three numbers n-x, n, or n+x will be a multiple of three.\n" +
					" Examples: \n" +
					" (3, 5, 7), (47, 53, 59), (151, 157, 163)\n" +
					" (167, 173, 179), (199, 211, 223)";
					break;

				case "Norm":
					radNm = "Regular Primes";
					Hlp = " Regular Prime Numbers:\n" +
					" Your everyday sequence of non-special Prime Numbers:\n" +
					" A Prime Number is any positive Integer greater than 1\n" +
					" that is divisable by itself and 1 only.\n" +
					" Examples:\n" +
					" 2, 3, 5, 7. 11. 13. 17. 19. 23, ...";
					break;

				case "BiTwn":
					Hlp = " Bi-twin Chain: \n" +
					" A sequence of prime numbers in the form \n" +
					" of length k - 1 is defined as a collection \n" +
					" of natural numbers: (n − 1, n + 1, 2n − 1, 2n + 1, …) \n" +
					" such that all the numbers in the chain are prime.";
					break;

				case "AriProg":
					Hlp = " I'm still working on this one so PLEASE get out of my face!";
					break;

				default: Hlp = " This is a royal pain in the rear ERROR!";
					break;
				}
			}

		public void ShowHlp(string Hlp, string radNm)
			{
			this.Enabled = true;
			this.Visible = true;
			this.Text = this.Text + this.radNm;
			this.rtbCatHlp.RichTextBox.Text = Hlp;
			}

		private void btnOK_Click(object sender, EventArgs e)
			{
			this.Enabled = false;
			this.Visible = false;
			this.Dispose();
			}

		}
	}
