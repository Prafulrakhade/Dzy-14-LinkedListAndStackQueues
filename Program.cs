using System;

namespace LinkedListProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------WELCOME TO THE LINKEDLIST  PROGRAM--------------------------\n\n");
            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Add(40);
            Console.WriteLine("Before deleting ");
            list.Display();
            list.Delete(40);
            int a = list.Size();
            Console.WriteLine("After deleting");
            list.Display();
            Console.WriteLine("After deleting Size is=" + a);
        }
    }
}
