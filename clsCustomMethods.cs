using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsCustomMethods
    {
        public static void FibonacciSeries()
        {
            int Prev = -1;
            int Next = 1;
            int Sum = 0;
            int numbers = 10;
            for (int i = 0; i < numbers; i++)
            {
                Sum = Next + Prev;
                Prev = Next;
                Next = Sum;
                Console.WriteLine("{0}", Sum);
            }
            Console.ReadLine();
        }

        public static void findTriplet()
        {
            int[] Arr = { 1, 2, 3, 4, 6, 7, 12, 13, 15 };
            int Sum = 10;
            for (int i = 0; i < Arr.Length - 2; i++)
            {
                for (int j = i + 1; j < Arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < Arr.Length; k++)
                    {
                        if (Arr[i] + Arr[j] + Arr[k] == Sum)
                        {
                            Console.WriteLine("{0},{1},{2}", Arr[i], Arr[j], Arr[k]);
                        }
                    }
                }
            }
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[k] });

                            Console.WriteLine("{0}&{1}&{2}", nums[i], nums[j], nums[k]);
                        }
                    }
                }
            }
            return result;
        }
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    for (int k = j + 1; k < nums.Length - 1; k++)
                    {
                        for (int l = k + 1; l < nums.Length; l++)
                        {
                            if (nums[i] + nums[j] + nums[k] + nums[l] == target)
                            {
                                result.Add(new List<int>() { nums[i], nums[j], nums[k], nums[l] });
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static void reverseString()
        {
            string strRev = "Bharath Vanathadupula";
            int strLength = strRev.Length - 1;
            string temp = "", rev = "";

            for (int i = 0; i <= strLength; i++)
            {
                temp += strRev[i];
                if ((strRev[i] == ' ') || (i == strLength))
                {
                    for (int j = temp.Length - 1; j >= 0; j--)
                    {
                        if (temp[j].ToString() != " ")
                            rev += temp[j];
                        if ((j == 0) && (i != strLength))
                            rev += " ";
                    }
                    temp = "";
                }
            }
            Console.WriteLine(rev);
        }

        public static void superNumber()
        {
            int sum = 0, rem;
            int num = 123;

            while (num != 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum + rem;
            }
            Console.WriteLine("Sum of digits is: {0}", sum);
        }
        public static int SqRoot(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }

            int i = 1, result = 1;

            while (result <= x)
            {
                i++;
                result = i * i;
            }
            return i - 1;
        }

    }
}
