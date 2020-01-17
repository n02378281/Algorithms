using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsReverseString
    {
        public static char[] ReverseString(char[] s)
        {

            string temp = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                temp = temp + s[i];
            }


            return temp.ToCharArray();
        }
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

        public static void reverseWithSpecialCharacters(char[] str)
        {
            // Initialize left and right pointers  
            int r = str.Length - 1, l = 0;

            // Traverse string from both ends until  
            // 'l' and 'r'  
            while (l < r)
            {
                // Ignore special characters  
                if (!char.IsLetter(str[l]))
                    l++;
                else if (!char.IsLetter(str[r]))
                    r--;

                // Both str[l] and str[r] are not spacial  
                else
                {
                    char tmp = str[l];
                    str[l] = str[r];
                    str[r] = tmp;
                    l++;
                    r--;
                }
            }
        }

        public static void printOutputForReverseWithSpecialCharacters()
        {
            String str = "a!!!b.c.d,e'f,ghi";
            char[] charArray = str.ToCharArray();

            Console.WriteLine("Input string: " + str);
            reverseWithSpecialCharacters(charArray);
            String revStr = new String(charArray);

            Console.WriteLine("Output string: " + revStr);
        }

        public static int[] PlusOne()
        {
            int[] digits = new int[] { 1, 2, 3 };
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newDigits = new int[digits.Length + 1];
            newDigits[0] = 1;
            return newDigits;
        }

        public static int ReverseAnInteger(int number)
        {
            int rem = 0;
            int rev = 0;
            while (number != 0)
            {
                rem = number % 10;
                rev = rev * 10 + rem;
                number = number / 10;
            }
            return rev;
        }

        public static string ReverseWords(string s)
        {
            int len = s.Length - 1;
            List<string> list = new List<string>();
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                    temp += s[i];
                if ((s[i] == ' ' && s[i - 1] != ' ') || (i == s.Length - 1))
                {
                    list.Add(temp);
                    temp = "";
                }
            }

            int left = 0; int right = list.Count - 1;

            while (left < right)
            {
                string temp1 = list[left];
                list[left] = list[right];
                list[right] = temp1;
                left++;
                right--;
            }
            string result = "";

            foreach (string item in list)
            {
                result +=  item + ' ';
            }
            return result.TrimEnd();
        }
    }
}
