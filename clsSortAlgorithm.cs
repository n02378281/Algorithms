using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    static class clsSortAlgorithm
    {
        /// <summary>
        /// Algorithm to Sort using Bubble Sort
        /// </summary>
        public static void BubbleSort()
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

            int temp = 0;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }

        public static void SelectionSort()
        {
            int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                Console.WriteLine( arr[i] + " ");
            }


            int swap = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[i])
                        i = j;

                swap = arr[i];
                arr[i] = arr[i];
                arr[i] = swap;
                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadLine();
        }

        public static void InsertionSort()
        {
            int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
            for (int i = 1; i < num.Length; i++)
            {
                int key = num[i];
                int j = i - 1;
                while (j >= 0 && num[j] > key)
                {
                    //loop
                    num[j + 1] = num[j];
                    j--;
                }
                num[j + 1] = key;
            }

            //display
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
