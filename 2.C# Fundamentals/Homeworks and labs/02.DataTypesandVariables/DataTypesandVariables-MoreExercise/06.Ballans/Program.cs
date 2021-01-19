using System;

namespace _06.Ballans
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counte1 = 0;
            int counter2 = 0;
            string no = "UNBALANCED";
            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();

                if (comand == "(")
                {
                    counte1++;
                }
                else if (comand == ")")
                {
                    counter2++;
                }

                if (counte1 > counter2)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }



            }
            if (counte1 == counter2)
            {
                Console.WriteLine( "BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
