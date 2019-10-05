using InterviewPrep.DesignPatterns.SOLID_Principles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterviewPrep.clsBinarytoDoubleLinkedList;

namespace InterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {   //Find Triplet 
            int[] Arr = { -1, 0, 1, 2, -1, -4 };
            clsCustomMethods.ThreeSum(Arr);
            int num = clsReverseString.ReverseAnInteger(-123);
            var value = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            clsReverseString.printOutputForReverseWithSpecialCharacters();

            //Find two elements in an array whose difference = given numebr
            clsMergeArray.findTwoElementsWhoseDiffIsGivenNumber();

            //Find two elements in an array whose sum = given numebr
            clsMergeArray.findTwoElementsWhoseSumIsGivenNumber();

            //Get max number of elements whose sum is equal to 20.
            List<int> numbers = new List<int>() { 1, 5, 5, 8, 9, 12, 19, 20, 4, 5, 7, 8, 6, 8, 7, 4, 1, 5, 9, 7, 1, 2 };
            int target = 20;
            clsSumOfNumberToGivenSum.sum_up(numbers, target);

            //LongestSubarrayMaxSum
            clsMergeArray.LongestSubarrayMaxSum();

            //Quick Sort Algorithm
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            clsSortAlgorithm.quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            clsSortAlgorithm.printArray(arr, n);

            //Merge two Arrays
            clsMergeArray.outputMergeArray();

            //Insertion Sorting Algorithms
            clsSortAlgorithm.InsertionSort();

            clsMergeSort.outputMergeSort();

            //Selection Sorting Algorithms
            clsSortAlgorithm.SelectionSort();

            //S.O.L.I.D
            SingleResponsibility.Method();

            //Select Sort Algorithm
            clsSelectSortAlgorithm.AlgSort();


            //Word Count
            clsWordCount.WordCount();

            //Bubble Sorting Algorithms
            clsSortAlgorithm.BubbleSort();

            //Fibonacci Series
            clsCustomMethods.FibonacciSeries();

            //Find Triplet
            clsCustomMethods.findTriplet();

            //Reverse String

            clsCustomMethods.reverseString();

            //Super NUmber
            clsCustomMethods.superNumber();

            //Print Rectangle of Stars "*" 
            //*********
            //**Hello**
            //**World**
            //**in   **
            //**a    **
            //**Frame**
            //**FName**
            //**LName**
            //*********
            clsPrintStarsinRectangle.printOutPut();

            //Binary Search Tree
            clsBinarySearchTree.PrintOutput();

            //Replace Dups with 0s
            clsReplaceDupsWithZeros.ReplaceDupsWithZeros();

            //Prime NUmbers [1-N]
            clsPrimeNumbersInAGivenRange.FindPrimeNumber();

            //Find duplicates in an Array
            clsFindDuplicateInAnArray.FindDuplicate();

            //Remove Duplicates in a String
            String s = clsRemoveDuplicatesInAString.removeDup("scbshbjab");
            Console.WriteLine(s);

            //Double Linked List
            clsDoubleLinkedList.DoublyLinkedListImpl<Int32>.Output();

            //Convert a Binary Tree to Double Linked list
            DLL d = new DLL();
            Tree t = new Tree();
            d.FromTree(t);
            d.Display();

            //Switch Pair of strings
            clsSwitchPairofStrings.switchWordsInString();

            //Split Function
            clsSplit.Split(' ', "Bharath Chandra Vanathadupula");

            //Trapping Rain Water
            clsTrappingRain.Trap(new int[12] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });

            //Polindrome
            clsPolindrome.PrintOutPut();

            //Binary Operators
            clsBinaryOperators.binaryOperators();

            //Convert String to Int
            clsStringtoInt.ConvertToNumber();
            clsStringtoInt.StringtoInt("125");

            //Reverse a String in a Sentence
            clsReverseString.ReverseWords();

            //Fibonacci
            clsFibonacci objFB = new clsFibonacci();
            objFB.FibonacciSeries();


            Console.ReadLine();
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            nums = new int[] { 2, 7, 11, 15 };
            target = 9;
            Dictionary<int, int> dictNum = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                if (dictNum.TryGetValue(target - num, out int index))
                {
                    return new int[] { index, i };
                }
                dictNum[num] = i;
            }
            return null;
        }
    }
}
