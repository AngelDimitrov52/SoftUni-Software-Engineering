using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    class DoublyLinkedList
    {
        private int count = 0;
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(Node node)
        {
            count++;
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
        }
        public void AddLast(Node node)
        {
            count++;
            if (Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
            }
        }
        public Node RemoveFirst()
        {
            if (Head == null)
            {
               return null;
            }
            var removeHead = Head;
            count--;
            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Previous = null;
            }
            else
            {
                Head = null;
                Tail = null;
            }
            return removeHead;
        }
        public Node RemoveLast()
        {
            if (Tail == null)
            {
                return null;
            }
            count--;
            var remove = Tail;
            if (Tail.Previous != null)
            {
                Tail = Tail.Previous;
                Tail.Next = null;
            }
            else
            {
                Tail = null;
                Head = null;
            }
            return remove;
        }
        public void ForEachFromHead(Action<Node> action)
        {
            var curentNode = Head;
            while (curentNode != null)
            {
                Console.WriteLine(curentNode.Value);
                curentNode = curentNode.Next;
            }
        }
        public void ForEachFromTail(Action<Node> action)
        {
            var curentNode = Tail;
            while (curentNode != null)
            {
                Console.WriteLine(curentNode.Value);
                curentNode = curentNode.Previous;
            }
        }
        public int[] ToArrays()
        {
            int[] array = new int[count];

            int counter = 0;
            var curentNode = Head;

            while (curentNode != null)
            {
                array[counter] = curentNode.Value;
                counter++;
                curentNode = curentNode.Next;
            }

            return array;
        }
    }
}
