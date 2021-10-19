using System;

namespace _03.Fixing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[5];
            weekDays[0] = "Sunday";
            weekDays[1] = "Monday";
            weekDays[2] = "Tuesday";
            weekDays[3] = "Wednesday";
            weekDays[4] = "Thursday";

            for (int i = 0; i <= 5; i++)
            {

                try
                {
                    Console.WriteLine(weekDays[i].ToString());
                }
                catch (IndexOutOfRangeException ec)
                {

                    Console.WriteLine(ec.Message);
                }
            }
            Console.ReadLine();
        }
    }
}
