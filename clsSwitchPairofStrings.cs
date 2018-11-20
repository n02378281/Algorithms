using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsSwitchPairofStrings
    {
        public static void switchWordsInString()
        {
            Console.WriteLine("Enter pair of words");
            String s = Console.ReadLine();
            if (s == null) throw new NullReferenceException();
            if (s == "") Console.WriteLine("");

            String[] words = s.Split(' ');
            if (words.Length == 1) Console.WriteLine(words[0]);

            StringBuilder str = new StringBuilder();
            for (int i = 0; i < words.Length - 1; i += 2)
            {
                //str.append(words[i + 1] + " " + words[i] + " ");
                str.Append(words[i + 1]);
                str.Append(" ");
                str.Append(words[i]);
                str.Append(" ");
            }

            Console.WriteLine(str.ToString());
        }

        public static String switchWordsInString(String s)
        {
            if ((s == null))
            {
                throw new NullReferenceException();
            }

            if ((s == ""))
            {
                return "";
            }

            String[] words = s.Split(' ');
            if ((words.Length == 1))
            {
                return words[0];
            }

            StringBuilder str = new StringBuilder();
            for (int i = 0; (i < (words.Length - 1)); i += 2)
            {
                // str.append(words[i + 1] + " " + words[i] + " ");
                str.Append(words[(i + 1)]);
                str.Append(" ");
                str.Append(words[i]);
                str.Append(" ");
            }
            Console.WriteLine(str);

            return str.ToString();
        }
    }
}
