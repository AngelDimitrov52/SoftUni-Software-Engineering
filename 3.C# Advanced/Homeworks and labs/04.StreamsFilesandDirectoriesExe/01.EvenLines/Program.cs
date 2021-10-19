using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                string currentRow = reader.ReadLine();
                int row = 0;

                while (currentRow != null)
                {
                    string[] line = currentRow.Split();
                    for (int i = 0; i < line.Length; i++)
                    {
                        string word = line[i];
                        if (word.Contains('-'))
                        {
                            line[i] = word.Replace('-', '@');
                        }
                        if (word.Contains(','))
                        {
                            line[i] = word.Replace(',', '@');
                        }
                        if (word.Contains('.'))
                        {
                            line[i] = word.Replace('.', '@');
                        }
                        if (word.Contains('!'))
                        {
                            line[i] = word.Replace('!', '@');
                        }
                        if (word.Contains('?'))
                        {
                            line[i] = word.Replace('?', '@');
                        }
                    }

                    if (row % 2 == 0)
                    {
                        Console.WriteLine(string.Join(" ", line.Reverse()));
                    }

                    currentRow = reader.ReadLine();
                    row++;
                }

            }
        }
    }
}
