using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class SubDomainsVisitsCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string sub in cpdomains)
            {
                string[] ss = sub.Split(' ');
                int count = int.Parse(ss[0]);

                string[] sss = ss[1].Split('.');
                string temp = "";
                for (int i = sss.Length - 1; i >= 0; i--)
                {
                    temp = string.IsNullOrEmpty(temp) ?
                        sss[i] : string.Format("{0}{1}{2}", sss[i], '.', temp);

                    if (!dic.ContainsKey(temp))
                    {
                        dic.Add(temp, count);
                    }
                    else
                    {
                        dic[temp] += count;
                    }
                }
            }
            return dic.Select(it => string.Format("{0} {1}", it.Value, it.Key)).ToList();
        }
    }
}
