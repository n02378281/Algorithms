using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            List<string> list = Split(s);

            StringBuilder builder = new StringBuilder();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                builder.Append(list[i]);
                if (i != 0)
                    builder.Append(' ');
            }

            return builder.ToString();
        }

        public List<string> Split(String str)
        {
            var result = new List<string>();

            int start = 0, count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    if (count > 0)
                    {
                        //result.Add(str.Slice(start, count).ToString());
                    }

                    start = i + 1;
                    count = 0;
                }
                else
                {
                    count++;
                }
            }

            if (count > 0)
            {
               // result.Add(str.Slice(start, count).ToString());
            }
            return result;
        }

        public void ReverseWords(char[] s)
        {
            if (s == null || s.Length == 0 || s.Length == 1)
                return;

            int start = 0,
                end = s.Length - 1;

            ReverseBlock(s, start, end);

            for (int k = 0; k <= s.Length - 1; k++)
            {
                if (s[k] == ' ' || k == s.Length - 1)
                {
                    if (s[k] == ' ')
                        end = k - 1;
                    else
                        end = k;

                    ReverseBlock(s, start, end);
                    start = k + 1;
                }
            }
        }
        private void ReverseBlock(char[] array, int start, int end)
        {
            while (start < end)
            {
                array[start] = (char)((int)array[start] + (int)array[end]);
                array[end] = (char)((int)array[start] - (int)array[end]);
                array[start] = (char)((int)array[start] - (int)array[end]);

                start++;
                end--;
            }
        }
    }
}
