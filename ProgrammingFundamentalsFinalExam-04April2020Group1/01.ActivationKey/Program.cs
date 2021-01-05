using System;

namespace _01.ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationkey = Console.ReadLine();

            string comand;
            while ((comand = Console.ReadLine()) != "Generate")
            {
                string[] comandArgs = comand.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                if (cmd == "Contains")
                {
                    string subString = comandArgs[1];
                    if (activationkey.Contains(subString))
                    {
                        Console.WriteLine($"{activationkey} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (cmd == "Flip")
                {
                    string lowUp = comandArgs[1];
                    int startIndex = int.Parse(comandArgs[2]);
                    int endIndex = int.Parse(comandArgs[3]);

                    string first = activationkey.Substring(0, startIndex);
                    string second = activationkey.Substring(startIndex, endIndex - startIndex);
                    string thurt = activationkey.Substring(endIndex);
                    if (lowUp == "Upper")
                    {
                        second = second.ToUpper();
                    }
                    else
                    {
                        second = second.ToLower();
                    }
                    activationkey = first + second + thurt;
                    Console.WriteLine(activationkey);

                }
                else if (cmd == "Slice")
                {
                    int startIndex = int.Parse(comandArgs[1]);
                    int endIndex = int.Parse(comandArgs[2]);

                    activationkey = activationkey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationkey);
                }

            }
            Console.WriteLine($"Your activation key is: {activationkey}");
        }
    }
}
