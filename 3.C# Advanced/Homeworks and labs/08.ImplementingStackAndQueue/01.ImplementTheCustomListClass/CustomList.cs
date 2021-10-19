namespace CustomStructures
{
    using System;

    public class CustomList
    {
        private const int initialCapacity = 2;
        private int[] itemArray;

        public int Count { get; private set; }

        public CustomList()
        {
            this.Count = 0;
            this.itemArray = new int[initialCapacity];
        }

        public CustomList(int initialSize)
            : this()
        {
            this.itemArray = new int[initialSize];
        }

        public int this[int index]
        {
            get
            {
                CheckIndexOutOfRange(index);
                return this.itemArray[index];
            }
            set
            {
                CheckIndexOutOfRange(index);
                this.itemArray[index] = value;
            }
        }

        public void Add(int element)
        {
            if (this.itemArray.Length == this.Count)
            {
                Resize();
            }

            this.itemArray[this.Count] = element;
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            CheckIndexOutOfRange(index);
            ShiftLeft(index);
            Shrink();

            this.Count--;
        }

        public void InsertAt(int index, int element)
        {
            CheckIndexOutOfRange(index);
            ShiftRight(index);

            this.itemArray[index] = element;
            this.Count++;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.itemArray[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIndexOutOfRange(firstIndex);
            CheckIndexOutOfRange(secondIndex);

            int tempElement = this.itemArray[firstIndex];
            this.itemArray[firstIndex] = this.itemArray[secondIndex];
            this.itemArray[secondIndex] = tempElement;
        }

        public void Shrink()
        {
            if (this.itemArray.Length / 4 > this.Count)
            {
                var temp = new int[this.itemArray.Length / 2];

                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.itemArray[i];
                }

                this.itemArray = temp;
            }
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                action(this.itemArray[i]);
            }
        }

        private void CheckIndexOutOfRange(int index)
        {
            if (index < 0 || index >= this.Count )
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void Resize()
        {
            Resize(this.itemArray.Length * 2);
        }

        private void Resize(int newSize)
        {
            var newValues = new int[newSize];

            for (int i = 0; i < itemArray.Length; i++)
            {
                newValues[i] = this.itemArray[i];
            }

            this.itemArray = newValues;
        }

        private void ShiftLeft(int index)
        {
            if (index < this.Count - 1)
            {
                for (int i = index; i < this.Count - 1; i++)
                {
                    this.itemArray[i] = this.itemArray[i + 1];
                }
            }

            this.itemArray[index] = default;
        }

        private void ShiftRight(int index)
        {
            if (this.itemArray.Length == this.Count)
            {
                Resize();
            }

            for (int i = this.Count - 1; i >= index; i--)
            {
                this.itemArray[i + 1] = this.itemArray[i];
            }

            this.itemArray[index] = default;
        }
    }
}