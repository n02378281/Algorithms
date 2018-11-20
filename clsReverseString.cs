using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsReverseString
    {
        //Without using In-Built
        public static void ReverseWords()
        {
            Console.WriteLine("Please Enter the String to Reverse? ");
            string str = Convert.ToString(Console.ReadLine());

            int strLeng = str.Length - 1;
            String reverse = "", temp = "";

            for (int i = 0; i <= strLeng; i++)
            {
                temp += str[i];
                if ((str[i] == ' ') || (i == strLeng))
                {
                    for (int j = temp.Length - 1; j >= 0; j--)
                    {
                        if (temp[j].ToString() != " ")
                            reverse += temp[j];
                        if ((j == 0) && (i != strLeng))
                            reverse += " ";
                    }
                    temp = "";
                }
            }
            Console.WriteLine(reverse);
        }
        //Using In-Built
        public static void ReverseWord()
        {
            Console.WriteLine("Please Enter the String to Reverse? ");
            string str = Convert.ToString(Console.ReadLine());
            string strrev = "";
            foreach (var word in str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + " ";
            }
            Console.WriteLine(strrev);
        }
    }
}
