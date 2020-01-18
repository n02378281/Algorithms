using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class MedianOfSortedArray
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int l1 = nums1.Length;
            int l2 = nums2.Length;
            double median = 0;

            int l3 = l1 + l2;
            List<int> lst = new List<int>();

            for (int i = 0; i < l1; i++)
            {
                lst.Add(nums1[i]);
            }

            for (int i = 0; i < l2; i++)
            {
                lst.Add(nums2[i]);
            }
            lst.Sort();
            if (l3 % 2 == 0)
            {
                return median = (double)(lst[l3 / 2 - 1] + lst[l3 / 2]) / 2;
            }
            else
            {
                return median = (double)lst[l3 / 2];
            }
            return median;
        }
    }
}
