
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using FndPrmCat;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace FndPrmCat
	{
	public class clsCalcPrimes
		{
		public static Font fntIn = new Font("Microsoft San Serif", 9.0F, FontStyle.Bold);
		public static FndPrmCat.frmFndPrmCat frmMy = new frmFndPrmCat();
		public static FndPrmCat.CatRslts myRslt = new FndPrmCat.CatRslts();
		//public static FndPrmCat.clsSelectCat myCat = new clsSelectCat();
		public static FndPrmCat.clsSelectCat myCat = new clsSelectCat();

		public clsCalcPrimes ()
			{
			// TODO: Nothing
			}

		// Overloaded constructor
		public clsCalcPrimes (int intCnt, int intInit, string strCat)
			{
			DoTheMath(intCnt, intInit, strCat);
			}
		
		public List<string> CalcCunChn (int intCnt, int intInit, string strCat)
			{
			int p = intInit;
			int b = 0;
			int c = 0;
			int i;
			int intSz = 0;
			string strP, strB, strC;
			List<string> lstRslt = new List<string>();
			for (i = 0, p = intInit; i < intCnt; p++)
				{
				b = ((p * 2) + 1);
				c = ((p * 2) - 1);

				if ((blnIsItPrm(p)) && (blnIsItPrm(b)))
					{
					strP = p.ToString();
					strB = b.ToString();
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strP + ", " + strB + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						}
					else if (i == intCnt - 1)
						{
						// This is the last pair so there will be no comma
						lstRslt.Add("(" + strP + ", " + strB + ")");
						intSz += intGetSz(lstRslt, fntIn);
						}
					i++;
					}
				else if ((blnIsItPrm(p)) && (blnIsItPrm(c)))
					{
					strP = p.ToString();
					strC = c.ToString();
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strP + ", " + strC + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						}
					else if (i == intCnt - 1)
						{
						// This is the last pair so there will be no comma
						lstRslt.Add("(" + strP + ", " + strC + ")");
						intSz += intGetSz(lstRslt, fntIn);
						}
					i++;
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);

			}

		public List<string> CalcBlncd (int intCnt, int intInit, string strCat)
			{
			int intPrv = 0;
			int intNxt = 0;
			string strPrv = "";
			string strNxt = "";
			string strP = "";
			int p;
			int i = 0;
			int j = intInit;
			int k = 0;
			List<string> lstRslt = new List<string>();

			for (j = 2; i < intCnt; j++)
				{
				p = j;
				// if p tests true as a prime, we proceed with  
				// our calcs, otherwise we bail out and go on to 
				// the next value of p
				if (blnIsItPrm(p) == true)
					{
					intNxt = GetNxt(p);
					// Find Next Prime
					if (!blnIsItPrm(intNxt))
						{
						continue;
						}
					intPrv = GetPrv(p);
					strNxt = intNxt.ToString();
					strPrv = intPrv.ToString();
					strP = p.ToString();
					if (!blnIsItPrm(intPrv))
						{
						continue;
						}
					if (intNxt - p != p - intPrv)
						{
						continue;
						}
					else
						{
						if(i != intCnt -1)
						{ 
						lstRslt.Add(("(" + strPrv + ", " + strP + ", " + strNxt + "), "));
						i++;
						}
						else // This is the last one
							{
							lstRslt.Add(("(" + strPrv + ", " + strP + ", " + strNxt + ")"));
							i++;
							}
						}
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		private static int GetPrv (int intIn)
			{
			int p = intIn;    // Given: p is Nth Prime number
			int i;								// Prev Prime is the (Nth - 1) 

			for (i = p - 1; ; i--)
				{
				if (!blnIsItPrm(i))
					{
					continue;
					}
				return (i);
				}
			}

		private static int GetNxt (int intIn)
			{
			int p = intIn;
			int i;

			for (i = p + 1; ; i++)
				{
				if (!blnIsItPrm(i))
					{
					continue;
					}
				return (i);
				}
			}

		public List<string> CalcSafe (int intCnt, int intInit, string strCat)
			{
			int i, j;
			int intPrm;
			int intPrv;
			int intNmbr = intCnt;
			string strPrm = "";
			string strPrv = "";
			List<string> lstRslt = new List<string>();
			// if intPrm is a prime & (intPrm - 1)/2 are primes
			// then we have a pair of safe primes :)

			for (i = 1, intPrm = intInit; i <= intNmbr; intPrm++)
				{
				intPrv = (intPrm - 1) / 2;
				if ((blnIsItPrm(intPrm) == true) && (blnIsItPrm(intPrv) == true))
					{
					strPrv = intPrv.ToString();
					strPrm = intPrm.ToString();
					if (i != intCnt)
						{
						lstRslt.Add(("(" + strPrv + ", " + strPrm + "), "));
						i++;
						}
					else // This is the last one
						{
						lstRslt.Add(("(" + strPrv + ", " + strPrm + ")"));
						i++;
						}
					}
				else
					{
					continue;
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcRglrPrm (int intCnt, int intInit, string strCat)
			{
			int p = 2;
			int i;
			int intSz = 0;
			bool blnPrm = false;
			string strP = "";
			List<string> lstRslt = new List<string>();

			for (i = 0, p = intInit; i < intCnt; p++)
				{
				blnPrm = blnIsItPrm(p);
				if (blnPrm == true)
					{
					strP = p.ToString();
					lstRslt.Add(strP + ", ");
					intSz += intGetSz(lstRslt, fntIn);
					i++;
					}
				else if (i == intCnt - 1)
					{
					strP = p.ToString();
					lstRslt.Add(strP);
					intSz += intGetSz(lstRslt, fntIn);
					i++;
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcDuets (int intCnt, int intInit, string strCat)
			{
			int p = intInit;
			int b = 0;
			int i;
			int intSz = 0;

			List<string> lstRslt = new List<string>();
			for (i = 0, p = intInit; i < intCnt; p++)
				{
				switch (strCat)
					{
					case "Twin": b = p + 2;
						break;
					case "Cousin": b = p + 4;
						break;
					case "Sexy": b = p + 6;
						break;
					case "Sophie Germain": b = ((p * 2) + 1);
						break;
					}
				if ((blnIsItPrm(p)) && (blnIsItPrm(b)))
					{
					string strP = p.ToString();
					string strB = b.ToString();
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strP + ", " + strB + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						}
					else if (i == intCnt - 1)
						{
						// This is the last pair so there will be no comma
						lstRslt.Add("(" + strP + ", " + strB + ")");
						intSz += intGetSz(lstRslt, fntIn);
						}
					i++;
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcTrplts (int intCnt, int intInit, string strCat)
			{
			bool blnA, blnB, blnC, blnD;
			int i, a, b, c, d;
			int p = intInit;
			int intSz = 0;
			string strA, strB, strC, strD;
			List<string> lstRslt = new List<string>();
			//			FndPrmCat.clsMath myMath = new FndPrmCat.clsMath();

			for (i = 0, p = intInit; i < intCnt; ++p)
				{
				a = p; b = p + 2; c = p + 4; d = p + 6;
				blnA = blnIsItPrm(a); blnB = blnIsItPrm(b);
				blnC = blnIsItPrm(c); blnD = blnIsItPrm(d);
				strA = a.ToString(); strB = b.ToString();
				strC = c.ToString(); strD = d.ToString();

				// triplets of form (p, p+2, p+6) 
				if (blnA && blnB && blnD)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA + ", " + strB + ", " + strD + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// last triplet
						lstRslt.Add("(" + strA + ", " + strB + ", " + strD + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}

					// triplets of form (p, p+4, p+6) 
				else if (blnA && blnC && blnD)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA + ", " + strC + ", " + strD + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// last triplet
						lstRslt.Add("(" + strA + ", " + strC + ", " + strD + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcSext (int intCnt, int intInit, string strCat)
			{
			bool blnA, blnB, blnC, blnD, blnE, blnF;
			int i, a, b, c, d, e, f;
			int p = intInit;
			int intSz = 0;
			string strA, strB, strC, strD, strE, strF;
			List<string> lstRslt = new List<string>();

			for (i = 0, p = intInit; i < intCnt; ++p)
				{
				a = p - 4; b = p; c = p + 2; d = p + 6; e = p + 8; f = p + 12;
				blnA = blnIsItPrm(a); blnB = blnIsItPrm(b); blnC = blnIsItPrm(c);
				blnD = blnIsItPrm(d); blnE = blnIsItPrm(e); blnF = blnIsItPrm(f);
				strA = a.ToString(); strB = b.ToString(); strC = c.ToString();
				strD = d.ToString(); strE = e.ToString(); strF = f.ToString();

				// Sextuplets of the form (p - 4, p, p+2, p+6, p + 8, p + 12) 
				if (blnA && blnB && blnC && blnD && blnE && blnF)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA + ", " + strB + ", " + strC + ", " + strD + ", " + strE + ", " + strF + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// last Sextuplet
						lstRslt.Add("(" + strA + ", " + strB + ", " + strC + ", " + strD + ", " + strE + ", " + strF + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcQuints (int intCnt, int intInit, string strCat)
			{
			bool blnA1, blnA2, blnB, blnC, blnD, blnE;
			int i, a1, a2, b, c, d, e, f;
			int p = intInit;
			int intSz = 0;
			string strA1, strA2, strB, strC, strD, strE;
			List<string> lstRslt = new List<string>();

			for (i = 0, p = intInit; i < intCnt; ++p)
				{
				a1 = p; a2 = p - 4; b = p + 2; c = p + 6; d = p + 8; e = p + 12;
				blnA1 = blnIsItPrm(a1); blnA2 = blnIsItPrm(a2);
				blnB = blnIsItPrm(b); blnC = blnIsItPrm(c);
				blnD = blnIsItPrm(d); blnE = blnIsItPrm(e);
				strA1 = a1.ToString(); strA2 = a2.ToString();
				strB = b.ToString(); strC = c.ToString();
				strD = d.ToString(); strE = e.ToString();

				// Quintuplets of the form (p, p+2, p+6, p + 8, p + 12) 
				if (blnA1 && blnB && blnC && blnD && blnE)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA1 + ", " + strB + ", " + strC + ", " + strD + ", " + strE + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// last Quintuplet
						lstRslt.Add("(" + strA1 + ", " + strB + ", " + strC + ", " + strD + ", " + strE + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}

					// Quintuplets of the form (p - 4, p, p + 2, p + 6, p + 8) 
				else if (blnA2 && blnA1 && blnB && blnC && blnD)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA2 + ", " + strA1 + ", " + strB + ", " + strC + ", " + strD + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// last triplet
						lstRslt.Add("(" + strA2 + ", " + strA1 + ", " + strB + ", " + strC + ", " + strD + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public List<string> CalcQuads (int intCnt, int intInit, string strCat)
			{
			bool blnA, blnB, blnC, blnD;
			int i, a, b, c, d;
			int p = intInit;
			int intSz = 0;
			string strA, strB, strC, strD;
			List<string> lstRslt = new List<string>();
			//			FndPrmCat.clsMath myMath = new FndPrmCat.clsMath();

			for (i = 0, p = intInit; i < intCnt; ++p)
				{
				a = p; b = p + 2; c = p + 6; d = p + 8;
				blnA = blnIsItPrm(a); blnB = blnIsItPrm(b);
				blnC = blnIsItPrm(c); blnD = blnIsItPrm(d);
				strA = a.ToString(); strB = b.ToString();
				strC = c.ToString(); strD = d.ToString();

				// Quadruplets of form (p, p+2, p+6) 
				if (blnA && blnB && blnD)
					{
					if ((i < intCnt) && (i != intCnt - 1))
						{
						lstRslt.Add("(" + strA + ", " + strB + ", " + strC + ", " + strD + "), ");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					else if (i == intCnt - 1)
						{
						// Last Quadruplet
						lstRslt.Add("(" + strA + ", " + strB + ", " + strC + ", " + strD + ")");
						intSz += intGetSz(lstRslt, fntIn);
						i++;
						}
					}
				}
			lstRslt = lstFmtRslts(lstRslt);
			return (lstRslt);
			}

		public int intGetSz (List<string> lstMyRslts, Font fntFnt)
			{
			string strFromList = lstMyRslts.Aggregate("", (current, s) => current + (s + ","));
			Image fakeImage = new Bitmap(1, 1);
			Graphics graphics = Graphics.FromImage(fakeImage);
			SizeF size = graphics.MeasureString(strFromList, fntFnt);

			return ((int)size.Width);
			}

		public List<string> lstFmtRslts (List<string> lstIn)
			{
			int intMaxChLn, intPcktCnt, intPcktLngth, i, intPcktChCnt;
			int intMaxLen = myRslt.Width;

			intPcktCnt = lstIn.Count;
			intMaxChLn = intGetMaxLength();
			intPcktLngth = 0;

			List<string> lstOut = new List<string>(lstIn);

			for (i = 0; i < intPcktCnt; i++)
				{
				intPcktChCnt = lstIn[i].Length;
				intPcktLngth += lstOut[i].Length;
				if (intPcktLngth >= intMaxChLn - intPcktChCnt)
					{
					lstOut[i] = lstOut[i].Insert(intPcktChCnt, "\r\n  ");
					intPcktLngth = 0;
					}
				}
			return (lstOut);
			}

		public static int intGetWdth (string lstIn)
			{
			int intLen = 0;
			Size txtSZ = TextRenderer.MeasureText(lstIn, fntIn);
			intLen = txtSZ.Width;
			return (intLen);
			}

		public static int intGetMaxLength ()
			{
			string strTst = "(9, 9), (99, 99), (999, 999), (9999, 9999), (99999, 99999), (999999, 999999)";
			int intTstLen = strTst.Length;
			int intStrLen = intGetWdth(strTst);
			double dblTstLen = (double)intTstLen;
			double dblStrLen = (double)intStrLen;
			double dblDivRslt = (dblStrLen / dblTstLen);
			dblDivRslt = Math.Ceiling(dblDivRslt);
			int intRTBLngth = myRslt.rtbRslts.Width - 10;
			int intChWdth = (int)dblDivRslt;
			int intMaxLngth = (int)(Math.Ceiling(((double)intRTBLngth) / ((double)intChWdth)));

			return (intMaxLngth);
			}

		public static bool blnIsItPrm (int intPrm)
			{
			if ((intPrm & 1) == 0)
				{
				if (intPrm == 2)
				{ return true; }
				else { return false; }
				}
			// reject perfect square
			// we've accounted for 2, so index starts at 3
			for (int i = 3; (i * i) <= intPrm; i += 2)
				{
				if ((intPrm % i) == 0)
				{ return false; }
				}
			// 1 is NOT a prime number (though many
			// of the unwashed masses believe otherwise), 
			// so eliminate it here
			return intPrm != 1;
			}

		public List<string> DoTheMath (int intCnt, int intInit, string strCat)
			{
			FndPrmCat.frmFndPrmCat.lstRslt = strCalcPrimes(intCnt, intInit, strCat);
			return (FndPrmCat.frmFndPrmCat.lstRslt);
			}

		public List<string> strCalcPrimes (int intCnt, int intInit, string strCat)
			{
			FndPrmCat.frmFndPrmCat.lstRslt.Clear();
			FndPrmCat.frmFndPrmCat.lstRslt = FndPrmCat.clsSelectCat.strCalcCat(intCnt, intInit, strCat);
			return (FndPrmCat.frmFndPrmCat.lstRslt);
			}

		public List<string> strRtn { get; set; }
		}
	}