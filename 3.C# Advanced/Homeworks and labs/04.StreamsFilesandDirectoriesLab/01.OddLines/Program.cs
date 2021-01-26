using System;
using System.IO;

namespace _01.Oddlines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../input.txt"))
            {
                string curentRow = reader.ReadLine();
                int row = 0;
                using (StreamWriter writer = new StreamWriter("../../../output.txt"))
                {

                    while (curentRow != null)
                    {
                        if (row % 2 == 1)
                        {
                            writer.WriteLine(curentRow);
                            
                        }
                        curentRow = reader.ReadLine();
                        row++;
                    }
                }
            }
           
        }
    }
}