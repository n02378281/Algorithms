using System;
using System.Collections;
using System.Collections.Generic;

namespace InterviewPrep.Prep
{
    class StackMin
    {
        int min = Int32.MaxValue;
        Stack<Int32> stack = new Stack<Int32>();
        public void push(int x)
        {
            // only push the old minimum value when the current 
            // minimum value changes after pushing the new value x
            if (x <= min)
            {
                stack.Push(min);
                min = x;
            }
            stack.Push(x);
        }

        public void pop()
        {
            // if pop operation could result in the changing of the current minimum value, 
            // pop twice and change the current minimum value to the last minimum value.
            if (stack.Pop() == min) min = stack.Pop();
        }

        public int top()
        {
            return stack.Peek();
        }

        public int getMin()
        {
            return min;
        }
    }

    public class MinStack2
    {
        public Stack s;
        public int minEle;

        // Constructor 
        public MinStack2()
        {
            s = new Stack();
        }

        // Prints minimum element of MyStack 
        public void getMin()
        {
            // Get the minimum number  
            // in the entire stack 
            if (s.Count == 0)
                Console.WriteLine("Stack is empty");

            // variable minEle stores the minimum  
            // element in the stack. 
            else
                Console.WriteLine("Minimum Element in the " +
                                " stack is: " + minEle);
        }

        // prints top element of MyStack 
        public void Peek()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }

            int t = (int)s.Peek(); // Top element. 

            Console.Write("Top Most Element is: ");

            // If t < minEle means minEle stores 
            // value of t. 
            if (t < minEle)
                Console.WriteLine(minEle);
            else
                Console.WriteLine(t);
        }

        // Removes the top element from MyStack 
        public void Pop()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("Top Most Element Removed: ");
            int t = (int)s.Pop();

            // Minimum will change as the minimum element 
            // of the stack is being removed. 
            if (t < minEle)
            {
                Console.WriteLine(minEle);
                minEle = 2 * minEle - t;
            }

            else
                Console.WriteLine(t);
        }

        // Insert new number into MyStack 
        public void Push(int x)
        {
            if (s.Count == 0)
            {
                minEle = x;
                s.Push(x);
                Console.WriteLine("Number Inserted: " + x);
                return;
            }

            // If new number is less than original minEle 
            if (x < minEle)
            {
                s.Push(2 * x - minEle);
                minEle = x;
            }

            else
                s.Push(x);

            Console.WriteLine("Number Inserted: " + x);
        }
    }
}
