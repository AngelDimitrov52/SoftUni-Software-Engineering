using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int bomb = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    bomb += int.Parse(text[i + 1].ToString());
                    continue;
                }
                if (bomb > 0)
                {
                    text = text.Remove(i,1);
                    bomb--;
                    i--;
                }

            }
            Console.WriteLine(text);
        }
    }
}
