using System;
using System.IO;

namespace _09.Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {

            string comand = Console.ReadLine();

            while (comand != "END")
            {
                bool isPolidrom = IsNumberIsPolidrom(comand);
                Console.WriteLine(isPolidrom.ToString().ToLower());


                comand = Console.ReadLine();
            }
            



        }

        private static bool IsNumberIsPolidrom(string comand)
        {
            int n = int.Parse(comand);
            int  r, sum = 0, temp;
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
            { 
                return true;
            }
            return false;
       
        }
    }
}
