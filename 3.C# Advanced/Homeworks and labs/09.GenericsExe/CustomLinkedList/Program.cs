using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            for (int i = 0; i < 10; i++)
            {
                list.AddFirst(new ListNode<string>(i.ToString()));
            }
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(new ListNode<string>(i.ToString()));
            }

            Console.WriteLine(list.RemoveFirst().Value + " remove");
            Console.WriteLine(list.RemoveFirst().Value + " remove");
            Console.WriteLine(list.RemoveFirst().Value + " remove");

            Console.WriteLine(list.RemoveLast().Value + " remove");
            Console.WriteLine(list.RemoveLast().Value + " remove");
            Console.WriteLine(list.RemoveLast().Value + " remove");

            list.ForEach(node => Console.WriteLine(node.Value));

            string[] array = list.ToArrays();

        }
    }
}
