using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsTrappingRain
    {
        public static int Trap(int[] height)
        {
            // left[i] contains height of tallest bar to the 
            // left of i'th bar including itself 
            int n = height.Length;
            int[] left = new int[n];

            // Right [i] contains height of tallest bar to 
            // the right of ith bar including itself 
            int[] right = new int[n];

            // Initialize result 
            int water = 0;

            // Fill left array 
            if (height.Length > 0)
            {
                left[0] = height[0];
                for (int i = 1; i < n; i++)
                    left[i] = Math.Max(left[i - 1], height[i]);

                // Fill right array 
                right[n - 1] = height[n - 1];
                for (int i = n - 2; i >= 0; i--)
                    right[i] = Math.Max(right[i + 1], height[i]);

                // Calculate the accumulated water element by element 
                // consider the amount of water on i'th bar, the 
                // amount of water accumulated on this particular 
                // bar will be equal to min(left[i], right[i]) - arr[i] . 
                for (int i = 0; i < n; i++)
                    water += Math.Min(left[i], right[i]) - height[i];
            }
            return water;
        }
    }
}
