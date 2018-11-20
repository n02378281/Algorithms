using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsStringtoInt
    {
        // Write a program to convert a string into number 
        //– like “1234.50”  to 1234.50
        public static void ConvertToNumber()
        {
            Console.WriteLine("Enter Number");
            string str = Console.ReadLine();
            int j = 0;
            int myNumber = 0;
            string strReverse = String.Empty;

            //Reverse the string
            foreach (char temp in str)
            {
                strReverse = temp + strReverse;
            }

            foreach (char temp in strReverse)
            {
                int i = temp - 48; //Ascii character
                myNumber = myNumber + i * myPower(10, j);
                j++;
            }
            Console.WriteLine(myNumber);
            Console.ReadLine();
        }

        public static int myPower(int i, int j)
        {
            int final = 1;
            for (int loop = 0; loop < j; loop++)
                final = final * i;
            return final;
        }

        public static void StringtoInt(String s)
        {
            Boolean isNegative = false;
            int number = 0;
            if (s[0] == '-')
            {
                isNegative = true;
            }
            else
            {
                number = number * 10 + s[0] - '0';
            }

            for (int i = 1; i < s.Length; i++)
            {

                number = number * 10 + s[i] - '0';
            }
            if (isNegative)
            {
                number = 0 - number;
            }
            Console.WriteLine("Number Converted from string to Integer: {0}", number);
        }
    }
}
