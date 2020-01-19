using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class RemoveDuplicatesInAnArray
    {
        public int RemoveDuplicates(int[] nums)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (map.ContainsKey(nums[i]))
                {
                    continue;
                }
                else
                {
                    map.Add(nums[i], 1);
                }
            }
            return map.Count;
        }

        public int RemoveDuplicates1(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int len = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[len] = nums[i];
                    len++;
                }
            }
            return len;
        }
    }
}

