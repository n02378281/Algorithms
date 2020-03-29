using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    // 763. Partition Labels
    public static class ArrPartitionLabels
    {
        public static IList<int> PartitionLabels(string s)
        {
            List<int> partitionLabels = new List<int>();
            int[] lastindexes = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                lastindexes[s[i] - 'a'] = i;
            }

            int x = 0;
            while (x < s.Length)
            {
                int end = lastindexes[s[x] - 'a'];
                int y = x;

                while (y != end)
                {
                    end = Math.Max(end, lastindexes[s[y++] - 'a']);
                }
                partitionLabels.Add(y - x + 1);
                x = y + 1;
            }

            return partitionLabels;

        }
    }
}
