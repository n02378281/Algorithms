using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    //Implement Stack Using Queue
    //Push Logic can be used to reverse queue.
    class StackUsingQueues
    {
        Queue<Int32> queue;

        public StackUsingQueues()
        {
            this.queue = new Queue<Int32>();
        }

        // Push element x onto stack.
        public void push(int x)
        {
            queue.Enqueue(x);
            for (int i = 0; i < queue.Count - 1; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        // Removes the element on top of the stack.
        public void pop()
        {
            queue.Dequeue();
        }

        // Get the top element.
        public int top()
        {
            return queue.Peek();
        }

        // Return whether the stack is empty.
        public Boolean empty()
        {
            return queue.Count == 0;
        }
    }
}
