using System;
using System.Linq;
using System.Text;

namespace _05.Digit_Letter_OrOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            StringBuilder digit = new StringBuilder();
            StringBuilder letter = new StringBuilder();
            StringBuilder other = new StringBuilder();



            for (int i = 0; i < text.Length; i++)
            {
                
                bool isDigit = char.IsDigit(text[i]);
                bool isLeter = char.IsLetter(text[i]);

                if (isDigit)
                {
                    digit.Append(text[i]);
                }
                else if (isLeter)
                {
                    letter.Append(text[i]);
                }
                else
                {
                    other.Append(text[i]);
                }
            }
            Console.WriteLine(digit.ToString());
            Console.WriteLine(letter.ToString());
            Console.WriteLine(other.ToString());
        }
    }
}
