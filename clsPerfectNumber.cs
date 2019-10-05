using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
   public class clsPerfectNumber
    {
        public static bool PerfectNumber(int num)
        {
            int sum = 1;
            for(int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    if (i * i != num)
                    {
                        sum = sum + i + num / i;
                    }
                    else
                    {
                        sum = sum + i;
                    }
                }
            }
            if (sum == num && num != 1)
            {
                return true;
            }
            return false;
        }
    }
}
