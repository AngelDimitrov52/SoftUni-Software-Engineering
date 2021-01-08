using System;

namespace _01._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] daytext ={ "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };
            int day = int.Parse(Console.ReadLine());

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid day!");
                
            }
            else
            {
            Console.WriteLine(daytext[day-1]);
                    
            }

           
        } 
    }
}
