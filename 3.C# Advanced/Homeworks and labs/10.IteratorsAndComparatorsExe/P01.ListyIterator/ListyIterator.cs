using System;
using System.Collections.Generic;
using System.Text;

namespace P01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int index = -1;

        public ListyIterator(params T[] elements)
        {
            list = new List<T>(elements);
            if (elements.Length > 0)
            {
                index = 0;
            }
        }

        public bool HasNext()
        {
            if (index < list.Count- 1)
            {
                return true;
            }
            return false;
        }
        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (index == -1)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(list[index]);
        }
    }
}
