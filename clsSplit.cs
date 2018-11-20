using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class clsSplit
    {
        public static void Split()
        {
            String s = Console.ReadLine();
            int count = 0;
            char[] c = s.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == ' ')
                {
                    count++;
                }
            }
            String temp = "";
            int k = 0;
            String[] rev = new String[count + 1];
            for (int i = c.Length - 1; i >= 0; i--)
            {
                if (c[i] == ' ')
                {
                    rev[k++] = temp;
                    temp = "";
                }
                else
                    temp = temp + c[i];
            }
            rev[k] = temp;

        }

        public static void Split(char delimeter, String line)
        {

            String word = "";
            String[] wordsArr = new String[3];

            int k = 0;
            for (int i = 0; i < line.Length; i++)
            {

                if (line[i] != delimeter)
                {
                    word += line[i];
                }
                else
                {
                    wordsArr[k] = word;
                    word = "";
                    k++;
                }
            }
            wordsArr[k] = word;
            for (int j = 0; j < wordsArr.Length; j++)
                Console.WriteLine(wordsArr[j]);

            Console.ReadLine();
        }
    }
}
