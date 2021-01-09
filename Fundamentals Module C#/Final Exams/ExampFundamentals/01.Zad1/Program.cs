using System;

namespace _01.Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string comand;
            while ((comand = Console.ReadLine())!= "Sign up")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                if (cmd == "Case")
                {
                    string cases = comandArgs[1];
                    if (cases=="lower")
                    {
                        text = text.ToLower();
                    }
                    else
                    {
                        text = text.ToUpper();
                    }
                    Console.WriteLine(text);

                }
                else if (cmd == "Reverse")
                {
                    int startIndex = int.Parse(comandArgs[1]);
                    int endIndex = int.Parse(comandArgs[2]);
                    if (startIndex >= 0 && startIndex < text.Length && endIndex >=0 && endIndex < text.Length)
                    {

                    string subString = text.Substring(startIndex, endIndex - startIndex + 1);
                    string revers = "";
                    for (int i = subString.Length -1 ; i >= 0; i--)
                    {
                        revers += subString[i];
                    }
                    Console.WriteLine(revers);
                    }
                }
                else if (cmd == "Cut")
                {
                    string subString = comandArgs[1];
                    if (text.Contains(subString))
                    {
                        text = text.Replace(subString, "");
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine($"The word {text} doesn't contain {subString}.");
                    }
                }
                else if (cmd == "Replace")
                {
                    string star = comandArgs[1];
                    if (text.Contains(star))
                    {

                    text = text.Replace(star, "*");
                    Console.WriteLine(text);
                    }
                }
                else if (cmd== "Check")
                {
                    string givenChar = comandArgs[1];
                    if (text.Contains(givenChar))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {givenChar}.");
                    }
                }
            }
        }
    }
}
