using System;

namespace _08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sum = 0;
            int counter = 0;
            int clas = 1;

            int i = 0;
            while ( i != 12)
            {
                double a = double.Parse(Console.ReadLine());
                
                if (a<4)
                {
                    counter++;
                    
                    if (counter==2)
                    {
                        break;
                    }
                    continue;
                }
                sum += a;
                clas++;
                i++;

            }
            if (clas <12)
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
            else
            {

            Console.WriteLine($"{name} graduated. Average grade: {sum*1.0 /12 :f2}");
            }
        }
    }
}
