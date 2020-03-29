using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrRegPattern
    {
        public static Boolean isMatch(String text, String pattern)
        {
            bool[,] dp = new bool[text.Length + 1, pattern.Length + 1];
            dp[text.Length, pattern.Length] = true;

            for (int i = text.Length; i >= 0; i--)
            {
                for (int j = pattern.Length - 1; j >= 0; j--)
                {
                    Boolean first_match = (i < text.Length &&
                                           (pattern[j] == text[i] ||
                                            pattern[j] == '.'));
                    if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                    {
                        dp[i, j] = dp[i, j + 2] || first_match && dp[i + 1, j];
                    }
                    else
                    {
                        dp[i, j] = first_match && dp[i + 1, j + 1];
                    }
                }
            }
            return dp[0, 0];
        }
        public static Boolean isMatch1(String text, String pattern)
        {
            bool[,] dp = new bool[text.Length + 1, pattern.Length + 1];
            dp[text.Length, pattern.Length] = true;

            for (int i = text.Length; i >= 0; i--)
            {
                for (int j = pattern.Length - 1; j >= 0; j--)
                {
                    Boolean first_match = (i < text.Length &&
                                           (pattern[j] == text[i] ||
                                            pattern[j] == '?'));
                    if (j + 1 < pattern.Length && pattern[j + 1] == '*')
                    {
                        dp[i, j] = dp[i, j + 2] || first_match && dp[i + 1, j];
                    }
                    else
                    {
                        dp[i, j] = first_match && dp[i + 1, j + 1];
                    }
                }
            }
            return dp[0, 0];
        }

        //We Tried solution for this Failed for few Scenarios
        public bool IsMatch(string s, string p)
        {

            int si = 0;
            int pi = 0;
            for (pi = 0; pi < p.Length && si < s.Length; pi++)
            {
                if ((p[pi] == s[si]) || p[pi] == '.')
                {
                    si++;
                }
                else if (p[pi] == '*')
                {
                    for (si = si; si < s.Length; si++)
                    {
                        if (p[pi - 1] == s[si])
                            continue;
                        else
                            break;
                    }
                    //failing for 5
                    if ((!(si < s.Length - 1)) && (!(pi < p.Length - 1)))
                        return true;
                }
                else if ((p[pi] != s[si]) && (p[pi + 1] == '*'))
                {
                    pi++;
                    continue;
                }
                else
                    return false;
            }
            if (!(pi < p.Length - 1))
                return false;

            if (si < s.Length - 1)
                return false;
            return true;
        }
    }
}
