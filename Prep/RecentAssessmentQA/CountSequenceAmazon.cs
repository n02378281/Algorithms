using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep.RecentAssessmentQA
{
    public class CountSequenceAmazon
    {
        /*Problem 1:
Since "Amazon" is often shortened to "Az" while texting, as part of an experiment, Amazon is keen on knowing how many "Az" subsequences there are in a word in their product reviews. Find the maximum possible count of subsequences after making the given operation.
More formally, given a string consisting of uppercase English letters, at most one character can be added anywhere in the string. Add at most 1 uppercase character to a string to maximize its number of "Az" subsequences.
Note: A subsequence of a string is created by deleting zero or more characters while maintaining the original order, For example, "AZ" is a subsequence of "SAKz" but not a subsequence of "ZKA".
Example
S= "AKZ"
One choice is to add an 'A' just after 'k' to make "AKAZ", The number of subsequences "AZ" in this is 2, which is the most possible.

Function Description
Complete the function maxmizeAZ in the editor below,

maxmizeAZ has the following parameters:
strings: the original string

Returns
int: the maximum number of "AZ" subsequences after adding at most one character

Constraints

1 s length of s≤ 10^5
s will only consist of uppercase English letters

Question 1:
Ans: */

        private static int CountSequenceAZ(String str)
        {
            if (str.Length <= 0 || (!str.Contains("Z") && !str.Contains("A")))
                return 0;
            bool atMostOneCharAdded = false;
            if (!str.Contains("Z") && str.Contains("A"))
            {
                str = str + "Z";
                atMostOneCharAdded = true;
            }
            else if (!str.Contains("A") && str.Contains("Z"))
            {
                str = "A" + str;
                atMostOneCharAdded = true;
            }

            Stack<char> stack = new Stack<char>();
            int i = 0;
            int count = 0;
            while (i < str.Length)
            {
                if (str[i] == 'Z')
                {
                    while (stack.Count > 0)
                    {
                        if (stack.Pop() == 'A')
                        {
                            count++;
                        }
                    }
                }
                stack.Push(str[i]);

                i++;
            }
            if (count > 0 && !atMostOneCharAdded)
                count += 1;
            return count;
        }


    }
}
