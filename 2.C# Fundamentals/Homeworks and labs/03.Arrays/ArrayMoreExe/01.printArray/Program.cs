using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace _01.printArray
{
    class Program
    {
        private static Array final;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] final = new int[n];
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            int todalSum = 0;
            for (int i = 0; i < n; i++)
            {
                string digit = arr[i];

                for (int j = 0; j < digit.Length; j++)
                {
                    int glasniSum = 0;
                    int suglasniSum = 0;
                    if (digit[j] == 'a' || digit[j] == 'e' || digit[j] == 'i' || digit[j] == 'u' || digit[j] == 'y' || digit[j] == 'o')
                    {
                        glasniSum = digit[j] * digit.Length;
                    }
                    else
                    {
                        suglasniSum = digit[j] / digit.Length;
                    }

                    todalSum = suglasniSum + glasniSum;
                }

              
                final[i] = todalSum;

            }


            for (int i = 0; i < final.Length; i++)
            {
                Console.WriteLine(final[i]);
            }




        }
    }
}
