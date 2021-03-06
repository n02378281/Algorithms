﻿using System;
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

            for (int i = 0; i< arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j+ 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int k = 0; k < arr.Length; k++)
                Console.Write(arr[k] + " ");

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

                Console.WriteLine(arr[i] + " ");
            }

            Console.ReadLine();
        }

        public static void InsertionSort()
        {
            int[] num = { 69, 56, 77, 44, 8, 0, 111, 566 };
            for (int i = 1; i < num.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && num[j] > num[i])
                {
                    //loop
                    num[j + 1] = num[j];
                    j--;
                }
                num[j + 1] = num[i];
            }

            //display
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        // A utility function to print array of size n 
        public static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}
