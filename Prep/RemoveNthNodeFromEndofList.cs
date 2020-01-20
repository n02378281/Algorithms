using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class RemoveNthNodeFromEndofList
    {
        //Using OnePass
        public ListNode removeNthFromEnd(ListNode head, int n)
        {

            ListNode start = new ListNode(0);
            ListNode slow = start, fast = start;
            slow.next = head;

            //Move fast in front so that the gap between slow and fast becomes n
            for (int i = 1; i <= n + 1; i++)
            {
                fast = fast.next;
            }
            //Move fast to the end, maintaining the gap
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            //Skip the desired node
            slow.next = slow.next.next;
            return start.next;
        }

        //Using Stack
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Stack<ListNode> nodeStack = new Stack<ListNode>();
            ListNode current = head;
            while (current != null)
            {
                nodeStack.Push(current);
                current = current.next;
            }
            for (int i = 0; i < n; i++)
            {
                nodeStack.Pop();
            }

            if (nodeStack.Count == 0)
            {
                return head.next;
            }
            ListNode previousRemoved = nodeStack.Peek();
            ListNode currentRemoved = previousRemoved.next;
            ListNode nextRemoved = currentRemoved.next;
            previousRemoved.next = nextRemoved;

            return head;
        }
    }
}
