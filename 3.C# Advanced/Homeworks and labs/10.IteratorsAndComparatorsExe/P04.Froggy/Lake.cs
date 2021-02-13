using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> lake;

        public Lake(int[] stones)
        {
            lake = new List<int>(stones);
        }
public IEnumerator<int> GetEnumerator()
        {
            int count = lake.Count;
            for (int i = 0; i < count; i+=2)
            {
                yield return lake[i];
            }
            if (count % 2 != 0)
            {
                count--;
            }
            for (int i = count - 1; i >= 0; i-=2)
            {
                yield return lake[i];

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
