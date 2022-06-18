using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public static class ReOrderLogFiles
    {
        // 937. Reorder Data in Log Files

        // Add to List

        //You are given an array of logs.Each log is a space-delimited string of words, where the first word is the identifier.

        //There are two types of logs:


        //Letter-logs: All words (except the identifier) consist of lowercase English letters.
        //Digit-logs: All words(except the identifier) consist of digits.
        //Reorder these logs so that:

        //The letter-logs come before all digit-logs.
        //The letter-logs are sorted lexicographically by their contents.If their contents are the same, then sort them lexicographically by their identifiers.
        //The digit-logs maintain their relative ordering.
        //Return the final order of the logs.

        //Example 1:

        //Input: logs = ["dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"]
        //Output: ["let1 art can","let3 art zero","let2 own kit dig","dig1 8 1 5 1","dig2 3 6"]
        //Explanation:
        //The letter-log contents are all different, so their ordering is "art can", "art zero", "own kit dig".
        //The digit-logs have a relative order of "dig1 8 1 5 1", "dig2 3 6".

        //Example 2:

        //Input: logs = ["a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"]
        //Output: ["g1 act car","a8 act zoo","ab1 off key dog","a1 9 2 3 1","zo4 4 7"]

        //Constraints:

        //1 <= logs.length <= 100
        //3 <= logs[i].length <= 100
        //All the tokens of logs[i] are separated by a single space.
        //logs[i] is guaranteed to have an identifier and at least one word after the identifier.

        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> letterLogFiles = new List<string>();
            List<string> digitLogFiles = new List<string>();

            foreach (var log in logs)
            {
                if (char.IsDigit(log[log.IndexOf(' ') + 1]))
                {
                    digitLogFiles.Add(log);
                }
                else
                {
                    letterLogFiles.Add(log);
                }
            }

            letterLogFiles.Sort((a, b) =>
            {
                string a_sub = a.Substring(a.IndexOf(' ') + 1);
                string b_sub = b.Substring(b.IndexOf(' ') + 1);

                var result = a_sub.CompareTo(b_sub);

                if (result == 0)
                {
                    result = a.Substring(0, a.IndexOf(' ')).CompareTo(b.Substring(0, b.IndexOf(' ')));
                }

                return result;
            });

            letterLogFiles.AddRange(digitLogFiles);

            foreach (var item in letterLogFiles)
            {
                Console.WriteLine("{0} ", item);
            }

            return letterLogFiles.ToArray();
        }
    }
}
