using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep.RecentAssessmentQA
{
    public class CalcuateGroups
    {
        /* Sliding Window problem:

        You are hosting a hackathon.
        Each team will have exactly teamSize developers.
        A developer's skill level is denoted by skill[i].
        The difference between the maximum and minimum skill levels within a team cannot exceed a threshold, maxDiff.
        Determine the maximum number of teams that can be formed from the contestants.
        Example:
        skill = [3, 4, 3, 1, 6, 5], teamSize = 3, maxDiff = 2: At most, 2 teams can be formed: [3, 3, 1] and [4, 6, 5].
        The difference between the maximum and minimum skill levels is 2 in each case, which does not exceed the threshold value of 2.

        */
        private static int CalcuateGroup(int[] skills, int teamSize, int maxDiff)
        {
            int res = 1;
            Array.Sort(skills);
            int startingIndex = 0;
            for (int index = 0; index < skills.Length; index++)
            {

                if (index - startingIndex == teamSize)
                {
                    startingIndex = index;
                    res++;
                    continue;
                }

                if (skills[index] - skills[startingIndex] > maxDiff)
                {
                    startingIndex = index;
                    res++;
                }
            }
            return res;
        }
    }
}
