using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P03.Stack
{
   public class MyStack<T> : IEnumerable<T>
    {
        private Stack<T> stack;

        public MyStack(params T[] element)
        {
            stack = new Stack<T>();
            foreach (var item in element)
            {
                stack.Push(item);
            }
        }

        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("No elements");
               
            }
            else
            {
                    
            T elemnt = stack.Pop();
            }
        }
        public void Push(T element)
        {
            stack.Push(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in stack)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
