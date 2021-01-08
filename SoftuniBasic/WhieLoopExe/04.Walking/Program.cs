using System;

namespace _04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepSum = 0;
            
            
            while (stepSum < 10000)
            {
               string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                  int  a = int.Parse(Console.ReadLine());
                    stepSum += a;
                    if (stepSum < 10000)
                    {
                        Console.WriteLine($"{10000 - stepSum} more steps to reach goal.");
                        
                    }
                    break;
                }
                stepSum += int.Parse(steps);
            }

            if (stepSum >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
        }
    }
}
