using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsPrimeNumbersInAGivenRange
    {
        public static void PrimeNumbers()
        {
            int i, j;
            Console.WriteLine("prime no between 1 to 100");
            for (i = 2; i <= 100; i++)
            {
                int count = 0;
                for (j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    { count = count + 1; }
                }

                if (count <= 2)
                { Console.WriteLine(i); }


            }
            Console.ReadKey();
        }

       public static void FindPrimeNumber()
        {
            long num;
            Console.WriteLine("Enter any value");
            num = Convert.ToInt64(Console.ReadLine());
            for (long i = 1; i <= num; i++)
            {
                int totalFactors = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        totalFactors = totalFactors + 1;
                    }
                }
                if (totalFactors == 2)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
