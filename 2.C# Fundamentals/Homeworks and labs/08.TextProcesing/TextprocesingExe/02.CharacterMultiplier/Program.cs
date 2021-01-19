using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] multies = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); 

            string shorter = "";
            string longer = "";

            if (multies[0].Length > multies[1].Length)
            {
                shorter = multies[1];
                longer = multies[0];
            }
            else
            {
                shorter = multies[0];
                longer = multies[1];
            }

            int sum = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                sum += (char)shorter[i] * (char)longer[i]; 
            }

            for (int i = shorter.Length ; i < longer.Length; i++)
            {
                sum += (char)longer[i];
            }
            Console.WriteLine(sum);





        }
    }
}
