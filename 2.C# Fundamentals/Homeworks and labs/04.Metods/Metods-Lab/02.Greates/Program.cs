using System;

namespace _02.Greates
{
    class Program
    {
        static void Main(string[] args)
        {
            double gread = double.Parse(Console.ReadLine());
            string str = ThheGreadIs(gread);
            Console.WriteLine(str);

        }

        private static string ThheGreadIs(double digit)
        {
            //•	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"

            string greadIs = String.Empty;
            if (digit <= 2.99 && digit >= 2.00)
            {
                greadIs = "Fail";
            }
            else if (digit <= 3.49)
            {
                greadIs = "Poor";
            }
            else if (digit <= 4.49)
            {
                greadIs = "Good";
            }
            else if (digit <= 5.49)
            {
                greadIs = "Very good";
            }
            else if (digit <= 6.00 && digit >= 5.50)
            {
                greadIs = "Excellent";
            }
            return greadIs;
        }
    }
}
