using System;

namespace _06.SpecialNumber
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

                            bool a = n % i == 0;
                            bool b = n % i1 == 0;
                            bool c = n % i2 == 0;
                            bool d = n % i3 == 0;

                            if (a && b && c &&d)
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
