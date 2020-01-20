using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
   public class LinkedListAddTwoNumbersII
    {
        public void PassLinkedList()
        {
            ListNode L1 = new ListNode(7);
            L1.next = new ListNode(2);
            L1.next.next = new ListNode(4);
            L1.next.next.next = new ListNode(3);

            ListNode L2 = new ListNode(5);
            L2.next = new ListNode(6);
            L2.next.next = new ListNode(4);

            var listNode = addTwoNumbers(L1, L2);
        }
        public ListNode addTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<Int32> s1 = new Stack<Int32>();
            Stack<Int32> s2 = new Stack<Int32>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            };
            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            int sum = 0;
            ListNode list = new ListNode(0);
            while (s1.Count != 0 || s2.Count != 0)
            {
                if (s1.Count != 0) sum += s1.Pop();
                if (s2.Count != 0) sum += s2.Pop();
                list.val = sum % 10;
                ListNode head = new ListNode(sum / 10);
                head.next = list;
                list = head;
                sum /= 10;
            }

            return list.val == 0 ? list.next : list;
        }

    }
}
