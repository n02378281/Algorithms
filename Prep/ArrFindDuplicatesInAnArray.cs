using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrFindDuplicatesInAnArray
    {
        public static void FindDuplicate()
        {
            int[] arr = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            findDuplicate(arr, arr.Length);
        }

        static void findDuplicate(int[] arr, int n)
        {
            Dictionary<int,
                   int> map = new Dictionary<int,
                                             int>();
            int count = 0;
            bool dup = false;
            for (int i = 0; i < n; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    count = map[arr[i]];
                    map[arr[i]]++;
                }
                else
                    map.Add(arr[i], 1);
            }

            foreach (KeyValuePair<int,
                                  int> entry in map)
            {
                // if frequency is more than 1  
                // print the element 
                if (entry.Value > 1)
                    Console.Write(entry.Key + " ");
                dup = true;
            }

            // no duplicates present 
            if (!dup)
                Console.WriteLine("-1");
        }
    }
}
