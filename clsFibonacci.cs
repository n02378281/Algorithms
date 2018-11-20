using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsFibonacci
    {
        public void FibonacciSeries()
        {
            int Prev = 1;
            int Next = -1;
            int Sum = 0;
            Console.WriteLine("How many fibonacci numbers you want to print? ");
            int numbers = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                Sum = Prev + Next;
                Console.WriteLine(Sum);
                Next = Prev;
                Prev = Sum;
            }
            Console.ReadLine();
        }

    }
}
