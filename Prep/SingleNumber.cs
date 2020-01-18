using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class SingleNumber
    {
        public int SingleNumber1(int[] nums)
        {
            if (nums == null)
                return -1;

            int sum = 0;
            foreach (var item in nums)
            {
                sum ^= item;
            }

            return sum;
        }
    }
}
