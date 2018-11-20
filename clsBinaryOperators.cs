using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsBinaryOperators
    {
        //Write a function to implement the binary operators
        public static void binaryOperators()
        {
            int a = 10, b = 30, c = 0;/*a= 0000 1010
                                        b= 0001 1110 */
            c = a & b;//00001010=10
            Console.WriteLine("Binary Operators for a&b is :{0}", c);
            c = a | b;//00011110=30
            Console.WriteLine("Binary Operators for a|b is :{0}", c);
            c = a ^ b;//
            Console.WriteLine("Binary Operators for a^b is :{0}", c);
            c = ~a;
            Console.WriteLine("Binary Operators for ~a is :{0}", c);
            c = a << 2;
            Console.WriteLine("Binary Operators for a<<2 is :{0}", c);
            c = a >> 2;
            Console.WriteLine("Binary Operators for a>>2 is :{0}", c);

            Console.ReadLine();
        }
    }
}
