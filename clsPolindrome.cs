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

        public static void PrintOutPut()
        {
            bool isPoli = Palindrome("5454");
            Console.WriteLine(isPoli);
            isPoli = isPalindrome("ABBA", 1, 2);
            Console.WriteLine(isPoli);
        }
    }
}
