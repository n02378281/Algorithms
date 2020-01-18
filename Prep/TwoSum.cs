using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class TwoSum
    {
        public int[] TwoSum1(int[] nums, int target)
        {
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
