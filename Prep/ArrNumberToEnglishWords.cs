using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrNumberToEnglishWords
    {
        private static string[] sectionNames = new string[]
   {
    "", "Thousand", "Million", "Billion", "Trillion"
   };

        private static string[] zeroToNineteenNames = new string[]
        {
    "Zero", "One", "Two", "Three", "Four",
    "Five", "Six", "Seven", "Eight", "Nine",
    "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen",
    "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static string[] twentyToNinety = new string[]
        {
    "", "", "Twenty", "Thirty", "Forty",
    "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        public static string NumberToWords(int num)
        {
            if (num == 0)
            {
                return zeroToNineteenNames[0];
            }
            string result = "";

            int temp = num;
            int sectionCount = 0;
            while (temp != 0)
            {
                int section = temp % 1000;
                temp = temp / 1000;

                if (section != 0)
                {
                    if (sectionCount >= 1)
                    {
                        result = sectionNames[sectionCount] + " " + result;
                    }
                    result = GetWordsForHundreds(section) + " " + result;
                }
                sectionCount++;
            }

            result = result.Replace("  ", " ");
            return result.Trim();
        }

        private static string GetWordsForHundreds(int num)
        {
            string result = "";
            int hundred = num / 100;
            if (hundred != 0)
            {
                result += zeroToNineteenNames[hundred] + " " + "Hundred";
            }
            int remain = num % 100;
            if (remain != 0)
            {
                if (remain < 20)
                {
                    result += " " + zeroToNineteenNames[remain];
                }
                else
                {
                    int ten = remain / 10;
                    if (ten != 0)
                    {
                        result += " " + twentyToNinety[ten];
                    }

                    int one = remain % 10;
                    if (one != 0)
                    {
                        result += " " + zeroToNineteenNames[one];
                    }
                }
            }
            return result;
        }
    }
}
