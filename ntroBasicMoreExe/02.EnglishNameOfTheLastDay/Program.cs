using System;

namespace _02.LastNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            num %= 10;
            string lastnum = string.Empty;
            switch (num)

            {
                case 1:
                    lastnum = "one";
                    break;
                case 2:
                    lastnum = "two";
                    break;
                case 3:
                    lastnum = "three";
                    break;
                case 4:
                    lastnum = "four";
                    break;
                case 5:
                    lastnum = "five";
                    break;
                case 6:
                    lastnum = "six";
                    break;
                case 7:
                    lastnum = "seven";
                    break;
                case 8:
                    lastnum = "eight";
                    break;
                case 9:
                    lastnum = "nine";
                    break;
                case 0:
                    lastnum = "zero";
                    break;


            }
            Console.WriteLine(lastnum);

        }
    }
}
