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
        //public void Add(int data)
        //{
        //    Node n = new Node(data);
        //    if (head == null)
        //    {
        //        head = n;
        //        Console.WriteLine("{0} inserted into the linkedList\n", n.data);
        //    }
        //    else
        //    {
        //        n.next = head;
        //        head = n;
        //        Console.WriteLine("{0} inserted into the linkedlist\n", n.data);
        //    }
        //}
        public void Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                Console.WriteLine("{0} Appended", n.data);
            }
            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            Console.WriteLine("{0} Appended", n.data);
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
