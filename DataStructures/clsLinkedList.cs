using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.DataStructures
{
    public class clsLinkedList
    {
        private class Node
        {
            private int value;
            private Node Next;

            public Node(int val)
            {
                this.value = val;
            }
        }

        private Node first;
        private Node last;

        public void addLast(int item)
        {
            var node = new Node(item);
            if(first == null)
            {
                first = last = node;
            }

        }
    }
}
