using System;

namespace _03.SimpleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int simpleSum = 0;
            int LordSum = 0;
            while (number != "stop")
            {
                int num = int.Parse(number);
                if (num <0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }
                else
                {
                    int counter = 0;
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            counter++;
                        }

                    }
                        if (counter == 2 )
                        {
                            simpleSum += num;
                        }
                       else if  (counter>2)
                        {
                            LordSum += num;
                        }
                }
                number = Console.ReadLine();
            }
                Console.WriteLine($"Sum of all prime numbers is: {simpleSum}");
                Console.WriteLine($"Sum of all non prime numbers is: {LordSum}");
        }
    }
}
