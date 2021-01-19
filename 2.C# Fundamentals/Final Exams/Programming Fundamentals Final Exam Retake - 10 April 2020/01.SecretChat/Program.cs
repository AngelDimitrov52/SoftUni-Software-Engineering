using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string comand;
            while ((comand = Console.ReadLine())!= "Reveal")
            {
                string[] comandArgs = comand.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];

                if (cmd == "InsertSpace")
                {
                    int index = int.Parse(comandArgs[1]);
                    text = text.Insert(index, " ");
                    Console.WriteLine(text);
                }
                else if (cmd == "Reverse")
                {
                    string subString = comandArgs[1];
                    if (text.Contains(subString))
                    {
                        int index = text.IndexOf(subString);

                        text = text.Remove(index, subString.Length);
                        for (int i = subString.Length-1; i >= 0; i--)
                        {
                            text += subString[i];
                        }
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "ChangeAll")
                {
                    string oldString = comandArgs[1];
                    string newString = comandArgs[2];
                    text = text.Replace(oldString, newString);
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"You have a new text message: {text}");
        }
    }
}
