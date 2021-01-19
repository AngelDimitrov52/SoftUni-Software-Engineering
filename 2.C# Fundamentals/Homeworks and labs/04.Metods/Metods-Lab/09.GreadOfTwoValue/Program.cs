using System;

namespace _09.GreadOfTwoValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstDigit = Console.ReadLine();
            string secondDigit = Console.ReadLine();
            if (type == "int")
            {

                Console.WriteLine(PrintBigDigit(type, firstDigit, secondDigit));
            }
            else if (type == "char")
            {
                PrintBigChar(firstDigit,secondDigit);
            }
            else if (type == "string")
            {
                PrntBigString(firstDigit,secondDigit);
            }







        }

        private static void PrntBigString(string firstDigit, string secondDigit)
        {
            string bigString = String.Empty;
            char firstChar = char.Parse(firstDigit[0].ToString());
            char secondChar = char.Parse(secondDigit[0].ToString());
            if (firstChar > secondChar)
            {
                bigString = firstDigit;
            }
            else
            {
                bigString = secondDigit;
            }
            Console.WriteLine(bigString);
        }

        private static void PrintBigChar(string firstDigit, string secondDigit)
        {
            string bigChar = String.Empty;
            char first = char.Parse(firstDigit);
            char second = char.Parse(secondDigit);
            if (first > second)
            {
                bigChar = first.ToString();
            }
            else
            {
                bigChar = second.ToString();
            }
            Console.WriteLine(bigChar);
        }

        private static string PrintBigDigit(string type, string firstDigit, string secondDigit)
        {
            int bigNum = 0;


            int first = int.Parse(firstDigit);
            int second = int.Parse(secondDigit);
            if (first > second)
            {
                bigNum = first;
            }
            else
            {
                bigNum = second;
            }



            return bigNum.ToString();
        }
    }
}
