using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class clsGroupAnagram
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<string, IList<string>>();
            foreach (var s in strs)
            {
                var chars = s.ToCharArray();
                Array.Sort(chars);
                var key = new string(chars);
                if (!dict.ContainsKey(key))
                {
                    dict[key] = new List<string>();
                }
                dict[key].Add(s);
            }
            var list = new List<IList<string>>();
            foreach (var kv in dict)
            {
                list.Add(kv.Value);
            }

            return list;
        }
        public IList<IList<string>> GroupAnagrams2(string[] strs)
        {
            if (strs == null)
            {
                return null;
            }

            int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103 };

            Dictionary<long, List<string>> res = new Dictionary<long, List<string>>();

            foreach (String x in strs)
            {
                long val = 1;

                for (int i = 0; i < x.Length; i++)
                {
                    val *= prime[x[i] - 'a'];
                }

                List<string> currentValue = null;

                if (res.ContainsKey(val))
                {
                    var oldlist = res[val];
                    oldlist.Add(x);
                    res[val] = oldlist;
                }
                else
                {
                    var newlist = new List<string>();
                    newlist.Add(x);
                    res[val] = newlist;
                }

                //   if (res.TryGetValue(val, out currentValue))
                //   {
                //       currentValue.Add(x);
                //  }
                //  else
                // {
                //     currentValue = new List<string>();
                //   currentValue.Add(x);
                //}

                //res[val] = currentValue;
            }

            IList<IList<string>> result = new List<IList<string>>();

            foreach (var pair in res)
            {
                IList<string> values = pair.Value;
                result.Add(values);
            }

            return result;
        }
    }
}
