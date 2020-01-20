using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrIsPalindrome
    {
        public bool IsPalindrome1(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                bool isLeft = IsAlphaNumeric(s[left]);
                bool isRight = IsAlphaNumeric(s[right]);

                if (isLeft && isRight)
                {
                    if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                        return false;
                    right--;
                    left++;
                }
                if (!isRight)
                {
                    right--;
                }
                if (!isLeft)
                {
                    left++;
                }
            }

            return true;
        }

        private bool IsAlphaNumeric(char v)
        {
            throw new NotImplementedException();
        }
    }
}
