using System;

namespace _05.ReversPasword
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            string reversName = "";

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                reversName +=  userName[i];
            }
            int counter = 0;
            string comand = Console.ReadLine();
            while (comand!= reversName)
            {
                counter++;
                if (counter==4)
                {
                    Console.WriteLine($"User { userName} blocked!");
                    return;
                }
                
                Console.WriteLine("Incorrect password. Try again.");
                 comand = Console.ReadLine();
            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
