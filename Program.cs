using System;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------WELCOME TO THE LINKEDLIST  PROGRAM--------------------------\n\n");
            LinkedList list = new LinkedList();
            //list.Add(70);
            //list.Add(56);           
            //list.Insert(1, 30);
            //list.Display();

            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.PopLast(2);
            list.Display();
        }
    }
}
