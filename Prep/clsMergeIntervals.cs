using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    public class clsMergeIntervals
    {
        //List<int[]> request = new List<int[]>();
        //request.Add(new int[2] { 1, 3 });
        //request.Add(new int[2] { 2, 6 });
        //request.Add(new int[2] { 15, 18 });
        //request.Add(new int[2] { 8, 10 });

        //var result = Merge(request.ToArray());
        //Console.WriteLine(result);

        public static int[][] Merge(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0)
                return new int[][] { };

            List<int[]> res = new List<int[]>();

            foreach (var item in intervals.OrderBy(x => x[0]).ToArray())
                if (res.Count == 0 || res[res.Count - 1][1] < item[0])
                    res.Add(item);
                else
                    res[res.Count - 1][1] = Math.Max(res[res.Count - 1][1], item[1]);

            return res.ToArray();
        }
    }
}
