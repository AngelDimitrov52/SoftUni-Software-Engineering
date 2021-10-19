using System;
using System.Collections.Generic;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            DoublyLinkedList list = new DoublyLinkedList();
            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(new Node(i));
            }
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(new Node(i));
            }

            Console.WriteLine(list.RemoveFirst().Value + " remove");
            Console.WriteLine(list.RemoveFirst().Value + " remove");
            Console.WriteLine(list.RemoveFirst().Value + " remove");

            Console.WriteLine(list.RemoveLast().Value + " remove");
            Console.WriteLine(list.RemoveLast().Value + " remove");
            Console.WriteLine(list.RemoveLast().Value + " remove");

            list.ForEachFromHead(node => Console.WriteLine(node.Value));
            list.ForEachFromTail(node => Console.WriteLine(node.Value));
   

            int[] array = list.ToArrays();
            
        }
    }
}
