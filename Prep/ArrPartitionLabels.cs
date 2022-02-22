using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    // 763. Partition Labels
    /*You are given a string s.
     * We want to partition the string into as many parts as possible so that each letter appears in at most one part.
     * Note that the partition is done so that after concatenating all the parts in order, the resultant string should be s.
     * Return a list of integers representing the size of these parts.
     * Input: s = "ababcbacadefegdehijhklij"
     * Output: [9,7,8]
     * Explanation:
     * The partition is "ababcbaca", "defegde", "hijhklij".
     * This is a partition so that each letter appears in at most one part.
     * A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.
     */
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
