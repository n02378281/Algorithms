using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrExcelSheetNumber
    {

        /// <summary>
        /// Given a column title as appear in an Excel sheet, return its corresponding column number.

        ///For example:

        ///A -> 1
        ///B -> 2
        ///C -> 3

        ///Z -> 26
        ///AA -> 27
        ///AB -> 28 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int TitleToNumber(string s)
        {

            int i = s.Length - 1; int j = 0, res = 0;

            while (i >= 0)
            {
                res += (int)Math.Pow(26, j) * ((s[i] - 'A') + 1);
                i--; j++;
            }
            return res;

        }
    }
}
