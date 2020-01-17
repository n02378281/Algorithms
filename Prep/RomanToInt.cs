using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class RomanToInt
    {
        public int RomanToInt1(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);
            int res = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1)
                {
                    if (map[s[i]] < map[s[i + 1]])
                    {
                        res += map[s[i + 1]] - map[s[i]];
                        i++;
                    }
                    else
                    {
                        res += map[s[i]];
                    }
                }
                else
                {
                    res += map[s[i]];
                }
            }
            return res;
        }

        public int RomanToIntReverseTraversal(string s)
        {
            var n = s.Length;
            var romanAndInt = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            var result = romanAndInt[s[n - 1]];

            for (int i = s.Length - 2; i >= 0; i--)
            {
                var cur = romanAndInt[s[i]];
                var post = romanAndInt[s[i + 1]];

                if (cur < post)
                {
                    result -= cur;
                }
                else
                {
                    result += cur;
                }
            }

            return result;
        }
    }
}
