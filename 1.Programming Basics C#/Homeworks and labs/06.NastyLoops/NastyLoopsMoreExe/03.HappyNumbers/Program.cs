using System;

namespace _03.HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int i1 = 1; i1 <= 9; i1++)
                {
                    for (int i2 = 1; i2 <= 9; i2++)
                    {
                        for (int i3 = 1; i3 <= 9; i3++)
                        {

                            if (i + i1 == i2 + i3)
                            {
                                if (n % (i+i1) == 0)
                                {
                                    Console.Write($"{i}{i1}{i2}{i3} ");
                                }


                            }


                        }
                    }

                }

            }






        }
    }
}
