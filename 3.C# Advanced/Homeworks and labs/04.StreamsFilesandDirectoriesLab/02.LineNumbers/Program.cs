using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string curentLine = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    int row = 1;
                    while (curentLine != null)
                    {

                        writer.WriteLine($"{row}. {curentLine}");


                        curentLine = reader.ReadLine();
                        row++;
                    }
                }
            }
        }
    }
}
