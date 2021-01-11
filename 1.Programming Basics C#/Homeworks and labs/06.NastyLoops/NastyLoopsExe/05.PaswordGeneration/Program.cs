using System;

namespace _05.PaswordGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (char i3 = 'a'; i3 < 'a'+ l; i3++)
                    {
                        for (char i4 = 'a'; i4 < 'a'+ l; i4++)
                        {
                            for (int i = 1; i <= n; i++)
                            {
                                if (i > i1 && i > i2)
                                {
                                    Console.Write($"{i1}{i2}{i3}{i4}{i} ");

                                }
                                
                                

                            }

                        }

                    }

                }

            }

        }
    }
}
