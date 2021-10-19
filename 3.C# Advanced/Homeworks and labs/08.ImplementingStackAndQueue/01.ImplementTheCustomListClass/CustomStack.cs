namespace CustomStructures
{
    using System;

    public class CustomStack
    {
        private const int initialcapacity = 4;
        private int[] itemArray;

        public int Count { get; private set; }

        public CustomStack()
        {
            this.Count = 0;
            this.itemArray = new int[initialcapacity];
        }

        public void Push(int item)
        {
            if (this.itemArray.Length == this.Count)
            {
                Resize();
            }

            this.itemArray[this.Count] = item;
            this.Count++;
        }

        public int Peek()
        {
            CheckStackCount();

            return this.itemArray[this.Count - 1];
        }

        public int Pop()
        {
            CheckStackCount();

            this.Count--;

            int temp = this.itemArray[this.Count];
            this.itemArray[this.Count] = default;

            return temp;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                action(this.itemArray[i]);
            }
        }

        private void Resize()
        {
            var copy = new int[this.itemArray.Length * 2];

            for (int i = 0; i < itemArray.Length; i++)
            {
                copy[i] = this.itemArray[i];
            }

            this.itemArray = copy;
        }

        private void CheckStackCount()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}