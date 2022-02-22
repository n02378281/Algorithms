using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep.RecentAssessmentQA
{
    public class GroupMoviesAwards
    {
        /* Problem 2:

Amazon Prime Video is a subscription video-on-demand over-the-top streaming and rental service. The team at Prime Video is developing a method to divide movies into groups based on the number of awards they have won. A group can consist of any number of movies, but the difference in the number of awards won by any two movies in the group must not exceed k.
The movies can be grouped together irrespective of their initial order. Determine the minimum number of groups that can be formed such that each movie is in exactly orly group.
Example
The numbers of awards per movie are awards = [1, 5, 4, 6, 8, 9, 21, and the maximum allowed difference is k = 3.

One way to divide the movies into the minimum number of groups is:

The first group can contain [2, 1], The maximum difference between awards of any two movies is 1 which does not exceed K.
The second group can contain [5, 4, 6], The maximum difference between awards of any two movies is 2 which does not exceed k.
The third group can contain [8,9]. The maximum difference between awards of any two movies is 1 which does not exceed k.
The movies can be divided into a minimum of 3 groups.

Function Description
Complete the function minimumGroups in the
editor below.
minimum Groups has the following parameters:
int awards[n]; the number of awards each movie has earned
int k: the maximum difference in awards counts */

        private static List<List<int>> GroupMoviesAward(int[] awards, int k)
        {
            List<List<int>> output = new List<List<int>>();
            if (awards.Length <= 0) return output;
            Array.Sort(awards);
            List<int> currGroup = new List<int>();
            for (int i = 0; i < awards.Length; i++)
            {
                if (currGroup.Count > 0 && awards[i] - currGroup[currGroup.Count - 1] <= k)
                {
                    for (int j = 0; j < currGroup.Count - 1; j++)
                    {
                        if (awards[i] - currGroup[j] > k)
                        {
                            output.Add(currGroup);
                            currGroup = new List<int>();
                            break;
                        }
                    }
                }
                else if (currGroup.Count > 0)
                {
                    output.Add(currGroup);
                    currGroup = new List<int>();
                }
                currGroup.Add(awards[i]);
            }
            if (currGroup.Count > 0 && currGroup.Count >= 2)
            {
                output.Add(currGroup);
            }
            return output;
        }
    }
}
