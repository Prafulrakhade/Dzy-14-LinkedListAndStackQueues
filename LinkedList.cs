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
        public bool Search(int data)
        {
            if (head == null)

                throw new NullReferenceException("List is Empty");

            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                if (t.data == data)

                    return true;
                Console.WriteLine("The given element {0} is present inside the Linked List", data);
                t = t.next;
            }
            return false;
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
