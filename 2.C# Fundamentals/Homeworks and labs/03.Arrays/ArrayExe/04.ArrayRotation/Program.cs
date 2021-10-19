using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string firstElement = arr[0];

                for (int j = 0; j < arr.Length-1; j++)
                {

                    arr[j] = arr[j + 1];


                }
                arr[arr.Length - 1] = firstElement;


            }
            Console.WriteLine(string.Join(" " , arr));






        }
    }
}
