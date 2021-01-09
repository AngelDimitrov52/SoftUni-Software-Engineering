using System;

namespace _05.Protect
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBee = int.Parse(Console.ReadLine());
            int bearHelt = int.Parse(Console.ReadLine());
            int bearAttak = int.Parse(Console.ReadLine());

            while (true)
            {
                numBee -= bearAttak;
                bearHelt -= numBee * 5;

                if (numBee < 100)
                {
                    break;
                }
                if (bearHelt <= 0)
                {
                    break;
                }

            }
            if (bearHelt <= 0 )
            {
                Console.WriteLine($"Beehive won! Bees left {numBee}.");
            }
            else
            {
                if (numBee < 0 )
                {
                    numBee = 0;
                }
                Console.WriteLine($"The bear stole the honey! Bees left {numBee}.");
            }


        }
    }
}
