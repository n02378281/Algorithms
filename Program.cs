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
            //Word Count
            clsWordCount.WordCount();
            //Convert String to Int
            clsStringtoInt.ConvertToNumber();
            clsStringtoInt.StringtoInt("125");
            //Reverse a String in a Sentence
            clsReverseString.ReverseWords();

           

            //Convert a Binary Tree to Double Linked list
            DLL d = new DLL();
            Tree t = new Tree();
            d.FromTree(t);
            d.Display();

            //Select Sort Algorithm
            clsSelectSortAlgorithm.AlgSort();

            //Fibonacci
            clsFibonacci objFB = new clsFibonacci();
            objFB.FibonacciSeries();


            Console.ReadLine();
        }
    }
}
