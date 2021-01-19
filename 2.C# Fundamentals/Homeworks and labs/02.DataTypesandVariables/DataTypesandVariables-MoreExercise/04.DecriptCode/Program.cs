using System;

namespace _04.DecriptCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char digit = char.Parse(Console.ReadLine());

                text += (char)(digit + key);

            }
            Console.WriteLine(text);
        }
    }
}
