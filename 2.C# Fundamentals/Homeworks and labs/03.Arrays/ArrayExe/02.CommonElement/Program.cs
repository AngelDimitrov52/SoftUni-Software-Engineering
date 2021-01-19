using System;

namespace _02.CommonElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secodArray = Console.ReadLine().Split();


            for (int i = 0; i < secodArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {

                    if (secodArray[i] == firstArray[j])
                    {
                        Console.Write($"{secodArray[i]} ");
                        break;
                    }


                }


            }
            
        }
    }
}
