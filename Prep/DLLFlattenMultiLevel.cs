using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class DLLFlattenMultiLevel
    {
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;

            public Node(int data)
            {
                this.val = data;
            }
        }

        public void FlattenDLL()
        {
            var dllNode = new Node(10);
            dllNode.next = new Node(20);
            dllNode.next.next = new Node(30);
            dllNode.next.next.next = new Node(40);
            dllNode.next.child = new Node(3);
            dllNode.next.child.next = new Node(4);
            dllNode.next.child.next.next = new Node(5);
            dllNode.next.child.next.child = new Node(6);
            dllNode.next.child.next.child.next = new Node(7);

            var res = flatten(dllNode);

        }

        public Node flatten(Node head)
        {
            if (head == null) return head;
            // Pointer
            Node p = head;
            while (p != null)
            {
                /* CASE 1: if no child, proceed */
                if (p.child == null)
                {
                    p = p.next;
                    continue;
                }
                /* CASE 2: got child, find the tail of the child and link it to p.next */
                Node temp = p.child;
                // Find the tail of the child
                while (temp.next != null)
                    temp = temp.next;
                // Connect tail with p.next, if it is not null
                temp.next = p.next;
                if (p.next != null) p.next.prev = temp;
                // Connect p with p.child, and remove p.child
                p.next = p.child;
                p.child.prev = p;
                p.child = null;
            }
            return head;
        }

        public Node flattenStack(Node head)
        {
            Stack<Node> stack = new Stack<Node>();
            Node travel = head;
            while (travel != null || stack.Count != 0)
            {
                if (travel.child != null)
                {
                    if (travel.next != null) stack.Push(travel.next);
                    travel.next = travel.child;
                    travel.next.prev = travel;
                    travel.child = null;
                }
                else
                {
                    if (travel.next == null && stack.Count != 0)
                    {
                        travel.next = stack.Pop();
                        travel.next.prev = travel;
                    }
                }
                travel = travel.next;
            }
            return head;
        }
    }
}
