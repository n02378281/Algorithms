using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class clsSelectSortAlgorithm
    {
        public static int[] a = new int[5] { 5, 7, 0, 8, 1 };

        public static void AlgSort()
        {
            Sort();
            foreach (int temp in a)
            {
                Console.WriteLine(temp);
            }
            Console.ReadLine();
        }

        public static void Sort()
        {
            int i, j;
            int min, temp;

            for (i = 0; i < a.Count() - 1; i++)
            {
                min = i;
                for (j = i + 1; j < a.Count(); j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                temp = a[i]; // Store the current value in temp variuable

                a[i] = a[min]; // Swap the minimum  value to the current position

                a[min] = temp; // Swap the current value to the minimum value position

            }
        }
    }

}
