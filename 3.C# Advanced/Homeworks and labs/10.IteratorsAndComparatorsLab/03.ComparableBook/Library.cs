using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>

    {
        private SortedSet<Book> books;

        public Library(params Book[] book)
        {
            books = new SortedSet<Book>(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> book)
            {
                Reset();
                books = new List<Book>(book);
            }
            public Book Current => books[currentIndex];
            object IEnumerator.Current => throw new NotImplementedException();
            public void Dispose(){}
            public bool MoveNext() => ++currentIndex < books.Count;
            public void Reset() => currentIndex = -1;
        }
    }
}
