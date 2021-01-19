using System;

namespace _07.MaxElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();

            int bestCounter = 0;
            int bestIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                string digit = arr[i];
                int curentCounter = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (digit == arr[j])
                    {

                        curentCounter++;
                    }
                    else
                    {
                        break;
                    }

                }
                if (curentCounter > bestCounter)
                {

                bestCounter = curentCounter;
                bestIndex = i;

                }


            }
            for (int i = 0; i < bestCounter; i++)
            {
                Console.Write($"{arr[bestIndex]} ");
            }






        }
    }
}
