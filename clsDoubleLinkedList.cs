using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    class clsDoubleLinkedList
    {
        public class DoublyLinkedListImpl<E>
        {
            public Node head;
            public Node tail;
            public int size;

            public DoublyLinkedListImpl()
            {
                size = 0;
            }
            /**
             * this class keeps track of each element information
             * @author java2novice
             *
             */
            public class Node
            {
                public E element;
                public Node next;
                public Node prev;

                public Node(E element, Node next, Node prev)
                {
                    this.element = element;
                    this.next = next;
                    this.prev = prev;
                }
            }
            /**
             * returns the size of the linked list
             * @return
             */
            public int sizeFinal()
            {
                return size;
            }

            /**
             * return whether the list is empty or not
             * @return
             */
            public Boolean isEmpty() { return size == 0; }

            /**
             * adds element at the starting of the linked list
             * @param element
             */
            public void addFirst(E element)
            {
                Node tmp = new Node(element, head, null);
                if (head != null) { head.prev = tmp; }
                head = tmp;
                if (tail == null) { tail = tmp; }
                size++;
                Console.WriteLine("adding: " + element);
            }

            /**
             * adds element at the end of the linked list
             * @param element
             */
            public void addLast(E element)
            {
                Node tmp = new Node(element, null, tail);
                if (tail != null) { tail.next = tmp; }
                tail = tmp;
                if (head == null) { head = tmp; }
                size++;
                Console.WriteLine("adding: " + element);
            }

            /**
             * this method walks forward through the linked list
             */
            public void iterateForward()
            {
                Console.WriteLine("iterating forward..");
                Node tmp = head;
                while (tmp != null)
                {
                    Console.WriteLine(tmp.element);
                    tmp = tmp.next;
                }
            }

            /**
             * this method walks backward through the linked list
             */
            public void iterateBackward()
            {
                Console.WriteLine("iterating backword..");
                Node tmp = tail;
                while (tmp != null)
                {
                    Console.WriteLine(tmp.element);
                    tmp = tmp.prev;
                }
            }

            /**
             * this method removes element from the start of the linked list
             * @return
             */
            public E removeFirst()
            {
                if (size == 0) throw new Exception();
                Node tmp = head;
                head = head.next;
                head.prev = null;
                size--;
                Console.WriteLine("deleted: " + tmp.element);
                return tmp.element;
            }

            /**
             * this method removes element from the end of the linked list
             * @return
             */
            public E removeLast()
            {
                if (size == 0) throw new Exception();
                Node tmp = tail;
                tail = tail.prev;
                tail.next = null;
                size--;
                Console.WriteLine("deleted: " + tmp.element);
                return tmp.element;
            }

            public static void Output()
            {
                DoublyLinkedListImpl<Int16> dll = new DoublyLinkedListImpl<Int16>();
                dll.addFirst(10);
                dll.addFirst(34);
                dll.addLast(56);
                dll.addLast(364);
                dll.iterateForward();
                dll.removeFirst();
                dll.removeLast();
                dll.iterateBackward();

                Console.ReadLine();
            }
        }
    }
}
