using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrIsPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            int newNum = 0, y = x;

            while (y >= 10)
            {
                newNum = 10 * newNum + y % 10;
                y /= 10;
            }

            return x < 0 ? false : newNum == x / 10;

        }
    }
}
