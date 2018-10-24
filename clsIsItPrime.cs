using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmTstTxt
	{
	class clsIsItPrime
		{
		public static bool blnIsItPrm(int intPrm)
			{
			if ((intPrm & 1) == 0)
				{
				if (intPrm == 2)
					{
					return true;
					}
				else
					{
					return false;
					}
				}

			//	we've accounted for 2, so index starts at 3

			for (int i = 3; (i * i) <= intPrm; i += 2)
				{
				if ((intPrm % i) == 0)
					{
					return false;
					}
				}

			//	Despite what many say, 
			//	1 is NOT a prime, so eliminate it here
			return (intPrm != 1);
			}
		}
	}
