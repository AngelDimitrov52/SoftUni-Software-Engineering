using System;


namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        private int count = 0;
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddFirst(ListNode<T> node)
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
        public void AddLast(ListNode<T> node)
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
        public ListNode<T> RemoveFirst()
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
        public ListNode<T> RemoveLast()
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
        public void ForEach(Action<ListNode<T>> action)
        {
            var curentNode = Head;
            while (curentNode != null)
            {
                Console.WriteLine(curentNode.Value);
                curentNode = curentNode.Next;
            }
        }

        public T[] ToArrays()
        {
            T[] array = new T[count];

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
