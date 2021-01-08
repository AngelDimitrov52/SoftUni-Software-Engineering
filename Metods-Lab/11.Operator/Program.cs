using System;

namespace _11.Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            string operatored = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine(OparatinOfNumers(firstNum, operatored, secondNum));


        }

        static double OparatinOfNumers(double firstNum, string operatored, double secondNum)
        {
            double result = 0;
            if (operatored == "+")
            {
                result = firstNum + secondNum;
            }
            else if (operatored == "-")
            {
                result = firstNum - secondNum;
            }
            else if (operatored == "*")
            {
                result = firstNum * secondNum;
            }
            else if (operatored == "/")
            {
                result = firstNum / secondNum;
            }
            return result;
        }
    }
}
