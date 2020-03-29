using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ArrMedianOfSortedArray
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

        public double findMedianSortedArrays(int[] A, int[] B)
        {
            int n = A.Length;
            int m = B.Length;
            // the following call is to make sure len(A) <= len(B).
            // yes, it calls itself, but at most once, shouldn't be
            // consider a recursive solution
            if (n > m)
                return findMedianSortedArrays(B, A);

            // now, do binary search
            int expMedian = (n + m - 1) / 2;
            int low = 0, middle = Math.Min(expMedian, n); // r is n, NOT n-1, this is important!!
            while (low < middle)
            {
                int midA = (low + middle) / 2;
                int midB = expMedian - midA;
                if (A[midA] < B[midB])
                    low = midA + 1;
                else
                    middle = midA;
            }

            // after binary search, we almost get the median because it must be between
            // these 4 numbers: A[low-1], A[low], B[expMedian-low], and B[expMedian-low+1] 

            // if (n+m) is odd, the median is the larger one between A[low-1] and B[expMedian-l].
            // and there are some corner cases we need to take care of.
            int a = Math.Max(low > 0 ? A[low - 1] : Int32.MinValue, expMedian - low >= 0 ? B[expMedian - low] : Int32.MinValue);
            if (((n + m) & 1) == 1)
                return (double)a;

            // if (n+m) is even, the median can be calculated by 
            //      median = (max(A[l-1], B[k-l]) + min(A[l], B[k-l+1]) / 2.0
            // also, there are some corner cases to take care of.
            int b = Math.Min(low < n ? A[low] : Int32.MaxValue, expMedian - low + 1 < m ? B[expMedian - low + 1] : Int32.MaxValue);
            return (a + b) / 2.0;
        }
    }
}
