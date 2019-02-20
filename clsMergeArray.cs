using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsMergeArray
    {
        // Merge arr1[0..n1-1] and  
        // arr2[0..n2-1] into  
        // arr3[0..n1+n2-1] 
        public static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

            // Traverse both array 
            while (i < n1 && j < n2)
            {
                // Check if current element  
                // of first array is smaller 
                // than current element 
                // of second array. If yes,  
                // store first array element  
                // and increment first array 
                // index. Otherwise do same  
                // with second array 
                if (arr1[i] < arr2[j])
                    arr3[k++] = arr1[i++];
                else
                    arr3[k++] = arr2[j++];
            }

            // Store remaining  
            // elements of first array 
            while (i < n1)
                arr3[k++] = arr1[i++];

            // Store remaining elements 
            // of second array 
            while (j < n2)
                arr3[k++] = arr2[j++];
        }

        public static void outputMergeArray()
        {
            int[] arr1 = { 1, 3, 8,5, 7 };
            int n1 = arr1.Length;

            int[] arr2 = { 2, 4,9, 6, 0 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];

            mergeArrays(arr1, arr2, n1, n2, arr3);

            Console.Write("Array after merging\n");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
        }

        //Find two elements in an array whose difference = given numebr
        static int countPairsWithDiffK(int[] arr, int n, int k)
        {
            int count = 0;

            // Pick all elements one by one 
            for (int i = 0; i < n; i++)
            {
                // See if there is a pair 
                // of this picked element 
                for (int j = i + 1; j < n; j++)
                    if (arr[i] - arr[j] == k ||
                          arr[j] - arr[i] == k)
                    {
                        Console.WriteLine("Elements are {0}, {1}", arr[i], arr[j]);
                        count++;
                    }
            }

            return count;
        }

        public static void findTwoElementsWhoseDiffIsGivenNumber()
        {
            int[] arr = { 1, 5, 3, 4, 2 };
            int n = arr.Length;
            int k = 3;

            Console.WriteLine("Count of pairs with " + " given diff is " + countPairsWithDiffK(arr, n, k));
        }

        //Find two elements in an array whose sum = given numebr
        public static void getPairsCount(int[] arr, int sum)
        {

            int count = 0; // Initialize result  

            // Consider all possible pairs  
            // and check their sums  
            for (int i = 0;
                     i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == sum)
                    {
                        Console.WriteLine("Elements are {0}, {1}", arr[i], arr[j] + "<br/>");
                        count++;
                    }

            Console.WriteLine("Count of pairs is " + count);
        }

        public static void findTwoElementsWhoseSumIsGivenNumber()
        {
            int[] arr = { 1, 5, 7, -1, 5 };
            int sum = 6;
            getPairsCount(arr, sum);
        }

        // function to find the  
        // maximum sum that  
        // exists in a subarray  
        static int maxSubArraySum(int[] arr, int size)
        {
            int max_so_far = arr[0];
            int curr_max = arr[0];

            for (int i = 1; i < size; i++)
            {
                curr_max = Math.Max(arr[i], curr_max + arr[i]);
                max_so_far = Math.Max(max_so_far, curr_max);
            }
            return max_so_far;
        }

        // function to find the  
        // length of longest  
        // subarray having sum k  
        static int lenOfLongSubarrWithGivenSum(int[] arr, int n, int k)
        {
            // unordered_map 'um' implemented  
            // as hash table  
            Dictionary<int,
                    int> um = new Dictionary<int,
                                            int>();
            int sum = 0, maxLen = 0;

            // traverse the given array  
            for (int i = 0; i < n; i++)
            {

                // accumulate sum  
                sum += arr[i];

                // when subarray starts  
                // from index '0'  
                if (sum == k)
                    maxLen = i + 1;

                // make an entry for 'sum' if  
                // it is not present in 'um'  
                if (um.ContainsKey(sum))
                    um.Add(sum, i);

                // check if 'sum-k' is present  
                // in 'um' or not  
                if (um.ContainsKey(sum - k))
                {

                    // update maxLength  
                    if (maxLen < (i - um[sum - k]))
                        maxLen = i - um[sum - k];
                }
            }

            // required maximum length  
            return maxLen;
        }

        // function to find the length  
        // of the longest subarray  
        // having maximum sum  
        static int lenLongSubarrWithMaxSum(int[] arr, int n)
        {
            int maxSum = maxSubArraySum(arr, n);
            return lenOfLongSubarrWithGivenSum(arr, n, maxSum);
        }

        public static void LongestSubarrayMaxSum()
        {
            int[] arr = { 5, -2, -1, 3, -4 };
            int n = arr.Length;
            Console.WriteLine("Length of longest subarray " + "having maximum sum = " + lenLongSubarrWithMaxSum(arr, n));
        }
    }
}
