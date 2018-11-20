using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsTrappingRain
    {
        public static void Trap(int[] height)
        {
            int l = height.Length;
            if (l < 3)
                Console.WriteLine(0);
            int[] leftMax = new int[l];
            int[] rightMax = new int[l];
            int maxL = height[0];
            int maxR = height[l - 1];
            for (int i = 0; i < l; i++)
            {
                maxL = height[i] > maxL ? height[i] : maxL;
                leftMax[i] = maxL;
                maxR = height[l - 1 - i] > maxR ? height[l - 1 - i] : maxR;
                rightMax[l - 1 - i] = maxR;
            }
            int waterTrapped = 0;
            for (int i = 0; i < l; i++)
            {
                waterTrapped += leftMax[i] > rightMax[i] ? rightMax[i] - height[i] : leftMax[i] - height[i];
            }
            Console.WriteLine(waterTrapped);
            Console.ReadLine();
        }
    }
}
