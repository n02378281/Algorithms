﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsSumOfNumberToGivenSum
    {
        public static void sum_up(List<int> numbers, int target)
        {
            sum_up_recursive(numbers, target, new List<int>());
        }

        public static void sum_up_recursive(List<int> numbers, int target, List<int> partial)
        {
            int s = 0;
            foreach (int x in partial) { s += x; }

            if (s == target)
                Console.WriteLine("sum(" + string.Join(",", partial.ToArray()) + ")=" + target);

            if (s >= target)
                return;

            for (int i = 0; i < numbers.Count; i++)
            {
                List<int> remaining = new List<int>();
                int n = numbers[i];
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    remaining.Add(numbers[j]);
                }

                List<int> partial_rec = new List<int>(partial);
                partial_rec.Add(n);
                sum_up_recursive(remaining, target, partial_rec);
            }
        }
    }

}
