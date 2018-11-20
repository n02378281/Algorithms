using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsFindDuplicateInAnArray
    {
        public static void FindDuplicate()
        {
            int start = 1;
            int end = 10;
            int[] arr = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(findDuplicate(arr, start, end));
        }

        static int findDuplicate(int[] arr, int start, int end)
        {
            int sumAll = 0;
            for (int i = start; i <= end; i++)
            {
                sumAll += i;
            }
            Console.WriteLine(sumAll);
            int sumArrElem = 0;
            ////for (int e; arr)
            ////{
            ////    sumArrElem += e;
            ////}
            Console.WriteLine(sumArrElem);
            return sumArrElem - sumAll;
        }
    }
}
