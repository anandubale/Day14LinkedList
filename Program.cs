using System;

namespace LinkedListProblems
{
    class Program
    {
        static void Main(string[]rgs)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Add(56);
            linkedlist.Add(30);
            linkedlist.Add(70);
            linkedlist.search(70);
            //linkedlist.RemoveFirstNode();
            //linkedlist.RemoveLastNode();
            //linkedlist.InsertAtParticularPosition(2, 30);
            linkedlist.Display();
            Console.ReadKey();

        }
    }
}
