using System;

namespace _02ZadachaDve
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are &lt; firstName & gt; &lt; lastName & gt;, a & lt; age & gt; -years old person from & lt; town & gt;.&quot;
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

        }
    }
}
