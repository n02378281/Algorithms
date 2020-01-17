using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class clsPolindrome
    {
        static int depth;
        //Recursive Polindrome
        public static bool Palindrome(string x)
        {
            depth++;
            if (depth == 1)
            {
                x = x.ToUpper().Trim();
                if (x.Equals(string.Empty) || x == null)
                {
                    return false;
                }
            }
            if (x.Length <= 1)
            {
                return true;
            }
            else
            {
                if (x[0] == x[x.Length - 1])
                {
                    x = x.Substring(1, x.Length - 2);
                    return Palindrome(x);
                }
                else
                {
                    return false;
                }
            }
        }

        public static bool isPalindrome(string value, int startChar, int endChar)
        {
            if (value[startChar] != value[endChar])
                return false;

            if (startChar >= endChar)
                return true;

            return isPalindrome(value, startChar + 1, endChar - 1);
        }

        public static String longestPalindrome(String s)
        {
            if (s == null || s.Length < 1) return "";//trpabcbadfhg
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);//1,1,1
                int len2 = expandAroundCenter(s, i, i + 1);//0,2 
                int len = Math.Max(len1, len2);//1
                if (len > end - start)
                {
                    start = i - (len - 1) / 2;//0
                    end = i + len / 2;//0
                }
            }
            return s.Substring(start, end - start + 1);
        }

        private static int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }

        public static void PrintOutPut()
        {
            bool isPoli = Palindrome("5454");
            Console.WriteLine(isPoli);
            isPoli = isPalindrome("ABBA", 1, 2);
            Console.WriteLine(isPoli);
        }

        }
}
