using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrLetterCombinationsofaPhoneNumber
    {
        public Queue<String> letterCombinations(String digits)
        {
            Queue<String> ans = new Queue<String>();
            if (String.IsNullOrEmpty(digits)) return ans;
            String[] mapping = new String[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            ans.Enqueue("");
            for (int i = 0; i < digits.Length; i++)
            {
                int x = (int)char.GetNumericValue(digits[i]);
                while (ans.Peek().Length == i)
                {
                    String t = ans.Dequeue();
                    foreach (char s in mapping[x].ToCharArray())
                        ans.Enqueue(t + s);
                }
            }
            return ans;
        }
    }
}
