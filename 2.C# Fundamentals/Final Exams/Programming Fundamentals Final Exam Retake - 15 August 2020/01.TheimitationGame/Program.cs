using System;

namespace _01.TheimitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine())!= "Decode")
            {
                string[] comandArgs = comand.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                if (cmd == "Move")
                {
                    int n = int.Parse(comandArgs[1]);
                    string move = text.Substring(0, n);
                    text += move;
                    text = text.Remove(0, n);
                }
                else if (cmd == "Insert")
                {
                    int index = int.Parse(comandArgs[1]);
                    string value = comandArgs[2];
                    text = text.Insert(index, value);
                }
                else if (cmd == "ChangeAll")
                {
                    string old = comandArgs[1];
                    string newsub = comandArgs[2];
                    text = text.Replace(old,newsub);
                }
            }
            Console.WriteLine($"The decrypted message is: {text}");
        }
    }
}
