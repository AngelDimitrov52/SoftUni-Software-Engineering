using System;

namespace P03.Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] webs = Console.ReadLine().Split();

            Smartphone smart = new Smartphone();
            StationaryPhone stat = new StationaryPhone();
            foreach (var item in numbers)
            {
                if (item.Length == 10)
                {
                    Console.WriteLine(smart.Call(item));
                }
                else
                {
                    Console.WriteLine(stat.Call(item));
                }
            }
            foreach (var item in webs)
            {
                Console.WriteLine(smart.Browsing(item));
            }
        }
    }
}
