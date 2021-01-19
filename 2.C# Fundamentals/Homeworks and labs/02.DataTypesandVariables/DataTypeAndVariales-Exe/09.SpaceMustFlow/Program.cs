using System;

namespace _09.SpaceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startDobiv = int.Parse(Console.ReadLine());
            int dobiv = 0;
            int counter = 0;
            while (startDobiv >= 100)
            {
                dobiv += startDobiv - 26;
                startDobiv -= 10;
                counter++;

            }
            if (dobiv >= 26)
            {
            dobiv -= 26;

            }
            Console.WriteLine(counter);
            Console.WriteLine(dobiv);

        }
    }
}
