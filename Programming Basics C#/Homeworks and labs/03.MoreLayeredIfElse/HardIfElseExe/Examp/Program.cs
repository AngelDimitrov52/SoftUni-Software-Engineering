using System;

namespace Examp
{
    class Program
    {
        static void Main(string[] args)
        {
            int exeH = int.Parse(Console.ReadLine());
            int exeMin = int.Parse(Console.ReadLine());
            int studentH = int.Parse(Console.ReadLine());
            int sudentMin = int.Parse(Console.ReadLine());

            int totalExeTime = exeH * 60 + exeMin;
            int totalStudentTime = studentH * 60 + sudentMin;

            int a = totalStudentTime - totalExeTime;
            int b = totalExeTime - totalStudentTime;
            if (totalExeTime < totalStudentTime)
            {
                Console.WriteLine("Late");
                if (a < 60)
                {
                    

                    Console.WriteLine($"{a}minutes after the start");
                }
                else
                {
                    int h = a / 60;
                    int min = a % 60;
                    Console.WriteLine($"{h}:{min:d2} hours after the start");
                }

            }
            else if (totalExeTime - totalStudentTime <=30 && totalExeTime - totalStudentTime >=0)
            {
                Console.WriteLine($"On time");
                if (b <= 30)
                {    
                    Console.WriteLine($"{b} minutes before the start");
                }
            }
            else if (totalExeTime - totalStudentTime > 30)
            {
                Console.WriteLine($"Early");
                if (b < 60)
                {
                    Console.WriteLine($"{b} minutes before the start");
                }

                else
                {
                    int h = b / 60;
                    int min = b % 60;
                    Console.WriteLine($"{h}:{min:D2} hours before the start");


                }
            }


        }
    }
}
