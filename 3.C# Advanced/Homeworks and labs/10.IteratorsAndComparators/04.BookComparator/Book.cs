using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int compere = Year.CompareTo(other.Year);
            if (compere == 0)
            {
                return Title.CompareTo(other.Title);
            }
            return compere;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }

}
