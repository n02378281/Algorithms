using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsWordCount
    {
        public static void WordCount()
        {
            Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            int num = 0;
            bool wasInaWord = true; 

            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine(num);
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (i != 0)
                {
                    if (str[i] == ' ' && str[i - 1] != ' ')
                    {
                        num++;
                        wasInaWord = false;
                    }
                }
                if (str[i] != ' ')
                {
                    wasInaWord = true;
                }
            }
            if (wasInaWord)
            {
                num++;
            }
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
