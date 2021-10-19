using System;

namespace _03.ZigZagArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] diit = Console.ReadLine().Split();
                if (i % 2 == 0 || i == 0)
                {
                    firstArray[i] = diit[0];
                    secondArray[i] = diit[1];
                }
                else
                {
                    secondArray[i] = diit[0];
                    firstArray[i] = diit[1];
                }


            }
            Console.WriteLine(string.Join(" " , firstArray));
            Console.WriteLine(string.Join(" " , secondArray));



        }
    }
}
