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
            if(head==null)
            {
                head = n;
                Console.WriteLine("{0} inserted into the linkedList", n.data);
            }
            else
            {
                n.next = head;
                head = n;
                Console.WriteLine("{0} inserted into the linkedlist", n.data);
            }
        }
    }
}
