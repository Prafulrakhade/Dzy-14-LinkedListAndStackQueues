using System;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------WELCOME TO THE LINKEDLIST  PROGRAM--------------------------\n\n");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Pop(56);
            list.Display();
        }
    }
}
