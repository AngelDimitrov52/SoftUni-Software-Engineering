using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> partyList = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();

                if (comand.Length == 3)
                {
                    bool isInParty = partyList.Contains(comand[0]);
                    if (!isInParty)
                    {
                    partyList.Add(comand[0]);

                    }
                    else
                    {
                        Console.WriteLine($"{comand[0]} is already in the list!");
                    }
                }
                else
                {
                    bool isInParty = partyList.Contains(comand[0]);
                    if (isInParty)
                    {
                        partyList.Remove(comand[0]);

                    }
                    else
                    {
                        Console.WriteLine($"{comand[0]} is not in the list!");
                    }


                }

            }
            Console.WriteLine(string.Join(Environment.NewLine, partyList));
        }
    }
}
