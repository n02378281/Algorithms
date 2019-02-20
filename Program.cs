﻿using InterviewPrep.DesignPatterns.SOLID_Principles;
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
        {
            //S.O.L.I.D
            SingleResponsibility.Method();
            //Convert a Binary Tree to Double Linked list
            DLL d = new DLL();
            Tree t = new Tree();
            d.FromTree(t);
            d.Display();

            //Select Sort Algorithm
            clsSelectSortAlgorithm.AlgSort();

            //Quick Sort Algorithm
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            clsSortAlgorithm.quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            clsSortAlgorithm.printArray(arr, n);

            //Selection Sorting Algorithms
            clsSortAlgorithm.SelectionSort();

            //Merge two Arrays
            clsMergeArray.outputMergeArray();

            //Find two elements in an array whose difference = given numebr
            clsMergeArray.findTwoElementsWhoseDiffIsGivenNumber();

            //Find two elements in an array whose sum = given numebr
            clsMergeArray.findTwoElementsWhoseSumIsGivenNumber();

            //LongestSubarrayMaxSum
            clsMergeArray.LongestSubarrayMaxSum();

            //Get max number of elements whose sum is equal to 20.
            List<int> numbers = new List<int>() { 1, 5, 5, 8, 9, 12, 19, 20, 4, 5, 7, 8, 6, 8, 7, 4, 1, 5, 9, 7, 1, 2 };
            int target = 20;
            clsSumOfNumberToGivenSum.sum_up(numbers, target);

            //Word Count
            clsWordCount.WordCount();

            //Bubble Sorting Algorithms
            clsSortAlgorithm.BubbleSort();


            //Insertion Sorting Algorithms
            clsSortAlgorithm.InsertionSort();

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
    }
}
