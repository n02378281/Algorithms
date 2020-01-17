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
        {
            Prep.TwoStacks ts = new Prep.TwoStacks(5);
            ts.push1(5);
            ts.push2(10);
            ts.push2(15);
            ts.push1(11);
            ts.push2(7);
            Console.WriteLine("Popped element from" +
                            " stack1 is " + ts.pop1());
            ts.push2(40);
            Console.WriteLine("Popped element from" +
                            " stack2 is " + ts.pop2());

            ListNode linkedList = new ListNode(1);
            var newList = linkedList;
            newList.next = new ListNode(10);

            var revll = ReverseLinkedList(linkedList);

            var llist = clsMergeTwoListNodes.MergeTwoListsRecurse(linkedList, revll);

            var y = clsReverseString.ReverseWords("the sky is blue");
            var rev = clsReverseString.ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });
            bool isRegPattern = clsRegPattern.isMatch("mississippi", "mis*is*p*.");
            //Tic Tac toe Number
            clsTicTacToe tictac = new clsTicTacToe(3);
            tictac.Move(0, 0, 1);
            tictac.Move(0, 2, 2);
            tictac.Move(2, 2, 1);
            tictac.Move(1, 1, 2);
            tictac.Move(2, 0, 1);
            tictac.Move(1, 0, 2);
            tictac.Move(2, 1, 1);
            //Quick Sort Algorithm
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            clsSortAlgorithm.quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array ");
            clsSortAlgorithm.printArray(arr, n);

            int valofStr = StringToIntAscii.MyAtoi("   -42 North");

            string ret = clsPolindrome.longestPalindrome("xyz134tgXABAN");
            string zig = clsZigzagConversion.Convert("PAYPALISHIRING", 4);

            FindMedianSortedArrays(new int[] { 40, 50, 60, 80, 90 }, new int[] { 30, 70, 100, 120, 150, 200 });

            //Switch Pair of strings
            clsSwitchPairofStrings.switchWordsInString();
            //Remove Duplicates in a String
            String s = clsRemoveDuplicatesInAString.removeDup("scbshbjab");
            Console.WriteLine(s);


            //Split Function
            clsSplit.Split(' ', "Bharath Chandra Vanathadupula");
            //Find duplicates in an Array
            clsFindDuplicateInAnArray.FindDuplicate();
            //Prime NUmbers [1-N]
            clsPrimeNumbersInAGivenRange.FindPrimeNumber();
            //Replace Dups with 0s
            clsReplaceDupsWithZeros.ReplaceDupsWithZeros();


            //Double Linked List
            clsDoubleLinkedList.DoublyLinkedListImpl<Int32>.Output();

            //Convert a Binary Tree to Double Linked list
            DLL d = new DLL();
            Tree t = new Tree();
            d.FromTree(t);
            d.Display();

            //Perfect Number
            bool val = clsPerfectNumber.PerfectNumber(14);

            //Find Triplet 
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



            //Trapping Rain Water
            int waterTrapped = clsTrappingRain.Trap(new int[12] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });

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


        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode reverseLinkedList = null;

            while (head != null)
            {
                ListNode temp = reverseLinkedList;
                reverseLinkedList = head;
                reverseLinkedList.next = temp;
                head = head.next;
            }
            return reverseLinkedList;
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

        //Analysis: Assuming nums2.Length is not greater than nums1.Length, there
        //          are only in total 4 cases need to be considered as below.
        //          We need only do divide and conquer on case 4.
        //          The relationship of cutpoint (mid1 and mid2) between nums1 and nums2 is:
        //           mid2 = (len1 + len2) / 2 - mid1 - 2;
        // Case 1: [][][][][][][][][]           <- nums1
        //               null                   <- nums2
        //
        // Case 2: [][][][][][]                 <- nums1
        //                     [][][][][][]     <- nums2
        //
        // Case 3:             [][][][][][][][] -< nums1
        //         [][][][][][]                 -< nums2
        //
        // Case 4: [][][][][][][][][]           -< nums1
        //           [][][][][][][]             -< nums2
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length, len2 = nums2.Length, halfIndex = (len1 + len2 - 1) / 2, odd = (len1 + len2) % 2, halfLength = (len1 + len2) / 2;
            if (len1 < len2) return FindMedianSortedArrays(nums2, nums1);
            //Case 1, 2
            if (len2 == 0 || nums1[len1 - 1] <= nums2[0])
                if (len1 != len2)
                    return odd == 1 ? nums1[halfIndex] : (nums1[halfIndex] + nums1[halfIndex + 1]) / 2d;
                else return (nums1[len1 - 1] + nums2[0]) / 2d;
            //Case 3
            if (nums2[len2 - 1] <= nums1[0])
                if (len1 != len2)
                    return odd == 1 ? nums1[halfIndex - len2] : (nums1[halfIndex - len2] + nums1[halfIndex - len2 + 1]) / 2d;
                else return (nums2[len1 - 1] + nums1[0]) / 2d;
            //Case 4
            for (int i = 0, j = len1 - 1, mid1 = (i + j) >> 1, mid2 = halfLength - mid1 - 2; ; mid1 = (i + j) >> 1, mid2 = halfLength - mid1 - 2)
                if (mid2 < -1) j = mid1 - 1;
                else if (mid2 >= len2) i = mid1 + 1;
                else
                {
                    int d11 = nums1[mid1], d12 = nums1[mid1 + 1];
                    int d21 = mid2 == -1 ? int.MinValue : nums2[mid2];
                    int d22 = mid2 + 1 == len2 ? int.MaxValue : nums2[mid2 + 1];
                    int d1 = Math.Max(d11, d21), d2 = Math.Min(d12, d22);

                    if (d11 > d22) j = mid1 - 1;
                    else if (d21 > d12) i = mid1 + 1;
                    else return odd == 1 ? d2 : (d1 + d2) / 2d;
                }

            return -1;
        }
    }

    //linked List class definition
    public class ListNode
    {
       public int val;
       public ListNode next;
       public ListNode(int x) { val = x; }
    }


    public class Solution
    {
        static int[,] MATRIX = { { 0, 0, 1, 0 },
                            { 0, 0, 1, 0 },
                            { 0, 0, 0, 0 },
                            { 0, 0, 1, 0 } };

        static bool knows(int a, int b)
        {
            bool res = (MATRIX[a, b] == 1) ?
                                         true :
                                         false;
            return res;
        }
        public int FindCelebrity(int n)
        {
            var ca = 0;

            for (var i = 1; i < n; i++) ca = knows(ca, i) ? i : ca;

            for (var i = 0; i < n; i++) if (i != ca && (knows(ca, i) || !knows(i, ca))) return -1;

            return ca;
        }
    }

    public class FindJudgeInTown
    {
        int N = 3;
        int[,] Matrix = {{1, 3},{2, 3},{3, 1}};

        public int FindJudge(int N, int[][] Matrix)
        {
            if (N == 1 && Matrix.Length == 0) return 1;

            var dict = new Dictionary<int, int>();

            for (var i = 0; i < Matrix.Length; i++)
            {
                dict[Matrix[i][1]] = dict.ContainsKey(Matrix[i][1]) ? dict[Matrix[i][1]] + 1 : 1;
            }

            if (dict.Count(d => d.Value == N - 1) != 1) return -1;

            var tj = dict.First(d => d.Value == N - 1).Key;

            for (var i = 0; i < Matrix.Length; i++)
            {
                if (Matrix[i][0] == tj) return -1;
            }

            return tj;
        }
    }
}
