using System;
using System.Text;

namespace _03.herosOfCodeAndLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string comand;
            while ((comand = Console.ReadLine()) != "Done")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                if (cmd == "TakeOdd")
                {
                    StringBuilder newPass = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPass.Append(password[i]);
                        }
                    }
                    password = newPass.ToString();
                    Console.WriteLine(password);
                }
                else if (cmd == "Cut")
                {
                    int index = int.Parse(comandArgs[1]);
                    int lenght = int.Parse(comandArgs[2]);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (cmd == "Substitute")
                {
                    string oldSub = comandArgs[1];
                    string newSub = comandArgs[2];
                    if (password.Contains(oldSub))
                    {
                        password = password.Replace(oldSub, newSub);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
