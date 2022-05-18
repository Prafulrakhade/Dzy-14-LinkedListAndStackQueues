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
        public void Insert(int index, int data)
        {
            Node n = new Node(data);
            if (index == 0)
            {
                n.next = head.next;
                head = n;
                Console.WriteLine("{0} is inserted into Linkedlist", n.data);
            }

            Node t = head, pre = null;
            while (index > 0 && t != null)
            {
                index--;
                pre = t;
                t = t.next;
            }
            if (index == 0)
            {
                pre.next = n;
                n.next = t;
                Console.WriteLine("{0} is inserted into LinkedList", n.data);
            }
           // throw new NullReferenceException("index is not in range\n");
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
