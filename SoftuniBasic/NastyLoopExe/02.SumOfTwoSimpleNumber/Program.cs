using System;

namespace _02.SumOfTwoSimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());


            for (int i = n; i <= g; i++)
            {
                string num = i.ToString();
                int oddSum = 0;
                int evensum = 0;

                for (int j = 0; j < num.Length ; j++)
                {
                    int chislo = int.Parse(num[j].ToString());
                    if (j % 2 == 0)
                    {
                        evensum += chislo;
                    }
                    else
                    {
                        oddSum += chislo;
                    }

                }
                if (evensum==oddSum)
                {
                    Console.Write(i + " ");
                }






            }


        }
    }
}
