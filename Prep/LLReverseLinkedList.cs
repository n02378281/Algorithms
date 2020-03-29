using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Prep
{
    class ReverseLinkedList<T> : IEnumerable
    {
        private Node<T> _head = null;

        public IEnumerator<T> Enumerator()
        {
            var current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return Enumerator();
        }
        public void Reverse()
        {
            Node<T> prev = null;
            var current = _head;

            if (current == null)
                return;

            while (current != null)
            {
                var next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            _head = prev;
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode res = null; ListNode temp = null;

            while (head.next != null)
            {
                temp = head;
                res = temp;
                res.next = temp;
                head = head.next;
            }

            return res;
        }
    }
}
