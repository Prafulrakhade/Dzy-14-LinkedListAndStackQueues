using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} inserted into the linkedList\n", n.data);
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} inserted into the linkedlist\n", n.data);
            }
        }
        public void Delete(int input)
        {
            if (head == null)
            {
                throw new NullReferenceException();
            }
            if (head.next == null)
            {
                head = null;
            }

            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data == input)
                {
                    pre.next = t.next;
                    Console.WriteLine("{0} data has been deleted from linked List", input);
                }
                pre = t;
                t = t.next;
            }
            throw new NullReferenceException("index is not in range");
        }

        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            Node t = head;
            int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;

        }
        public void Display()
        {
            Console.WriteLine("Displaying the LinkedList elements\n");
            Node t = head;
            if (t == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            while (t != null)
            {
                Console.WriteLine(t.data + " ");
                t = t.next;
            }
        }
    }
}
