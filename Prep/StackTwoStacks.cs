using System;

namespace InterviewPrep.Prep
{
    public class StackTwoStacks
    {
        public int size;
        public int top1, top2;
        public int[] arr;

        // Constructor 
        public StackTwoStacks(int n)
        {
            arr = new int[n];
            size = n;
            top1 = -1;
            top2 = size;
        }

        // Method to push an element x to stack1 
        public virtual void push1(int x)
        {
            // There is at least one empty 
            // space for new element 
            if (top1 < top2 - 1)
            {
                top1++;
                arr[top1] = x;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
                Environment.Exit(1);
            }
        }

        // Method to push an element x to stack2 
        public virtual void push2(int x)
        {
            // There is at least one empty 
            // space for new element 
            if (top1 < top2 - 1)
            {
                top2--;
                arr[top2] = x;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
                Environment.Exit(1);
            }
        }

        // Method to pop an element 
        // from first stack 
        public virtual int pop1()
        {
            if (top1 >= 0)
            {
                int x = arr[top1];
                top1--;
                return x;
            }
            else
            {
                Console.WriteLine("Stack Underflow");
                Environment.Exit(1);
            }
            return 0;
        }

        // Method to pop an element 
        // from second stack 
        public virtual int pop2()
        {
            if (top2 < size)
            {
                int x = arr[top2];
                top2++;
                return x;
            }
            else
            {
                Console.WriteLine("Stack Underflow");
                Environment.Exit(1);

            }
            return 0;
        }
    }


}
