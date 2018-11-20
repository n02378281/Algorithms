using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsPrintStarsinRectangle
    {
            public static int maxLengthOfString(List<string> array)
            {
                int maxStringLength = 0;

                for (var i = 0; i < array.Count; i++)
                {
                    if (array[i].Length > maxStringLength)
                    {
                        maxStringLength = array[i].Length;
                    }
                }

                maxStringLength += 4; //To add additional space

                return maxStringLength;
            }

            public static void printAstricInLine(int maxStringLength)
            {
                for (var index = 0; index < maxStringLength; index++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            public static void printAstricAndString(string stringName, int maxStringLength)
            {
                Console.Write("* ");

                var needtoBeAddedSpace = maxStringLength - stringName.Length;

                needtoBeAddedSpace -= 3;

                for (var index = 0; index < needtoBeAddedSpace; index++)
                {
                    stringName = stringName + " ";
                }
                stringName = stringName + "*";

                Console.WriteLine(stringName);
            }

            public static void printOutPut()
            {
                List<string> array = new List<string>() { "Hello", "World", "in", "a", "frame", "My First Name", "My Last Name" }; ;

                int maxStringLength = maxLengthOfString(array);

                //Print first line
                printAstricInLine(maxStringLength);

                //Print astrinc and text combination
                for (var index = 0; index < array.Count; index++)
                {
                    printAstricAndString(array[index], maxStringLength);
                }
                //Print last line
                printAstricInLine(maxStringLength);

                Console.ReadKey();
            }
                
    }
}
