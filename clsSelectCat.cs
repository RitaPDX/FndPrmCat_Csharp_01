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
	public class clsSelectCat
		{

		public clsSelectCat()
			{

			}

		public static FndPrmCat.clsCalcPrimes myCalc = new clsCalcPrimes();
		public static List<string> strCalcCat (int intCnt, int intInit, string strCat)
			{
			switch (strCat)
				{
				case "Twin":
				case "Cousin":
				case "Sexy":
				case "Sophie Germain": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcDuets(intCnt, intInit, strCat);
					break;
				// -------------------------------------------------------
				// ----------------------  tuplets  ----------------------
				// -------------------------------------------------------
				case "Triplet": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcTrplts(intCnt, intInit, strCat);
					break;
				case "Quadruplet": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcQuads(intCnt, intInit, strCat);
					break;
				case "Quintuplet": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcQuints(intCnt, intInit, strCat);
					break;
				case "Sextuplet": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcSext(intCnt, intInit, strCat);
					break;
				// -------------------------------------------------------
				// -------------------  all the rest  --------------------
				// -------------------------------------------------------
				case "Cunningham Chain": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcCunChn(intCnt, intInit, strCat);
					break;
				case "Safe": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcSafe(intCnt, intInit, strCat);
					break;
				case "Balanced": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcBlncd(intCnt, intInit, strCat);
					break;
				case "Regular Primes": FndPrmCat.frmFndPrmCat.lstRslt = myCalc.CalcRglrPrm(intCnt, intInit, strCat);
					break;
				}
			return (FndPrmCat.frmFndPrmCat.lstRslt);
			}
		}
	}
