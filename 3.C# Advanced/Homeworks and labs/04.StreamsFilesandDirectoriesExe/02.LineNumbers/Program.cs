using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Lines = File.ReadAllLines("../../../text.txt");
            
            for (int i = 0; i < Lines.Length; i++)
            {
                int counterLeter = 0;
                int counterPunctuacion = 0;

                foreach (var item in Lines[i])
                {
                    if (char.IsLetter(item))
                    {
                        counterLeter++;
                    }
                    else if (char.IsPunctuation(item))
                    {
                        counterPunctuacion++;
                    }
                }

                string upDateLine =
                    $"Line {i+1}: {Lines[i]} ({counterLeter})({counterPunctuacion})";
                File.AppendAllText("../../../output.txt",upDateLine + Environment.NewLine);

            }

        }
    }
}
