using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var item in banedWords)
           
            {
                string replais = new string('*', item.Length);
                
                text = text.Replace(item,replais);
            }
            Console.WriteLine(text);





        }
    }
}
