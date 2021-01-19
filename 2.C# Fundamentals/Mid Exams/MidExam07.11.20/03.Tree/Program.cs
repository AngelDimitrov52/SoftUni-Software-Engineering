using System;
using System.Collections.Generic;

namespace _03.Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chatList = new List<string>();

            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string com = comandArgs[0];

                if (com == "Chat")
                {
                    string message = comandArgs[1];
                    chatList.Add(message);
                }
                else if (com == "Delete")
                {
                    string message = comandArgs[1];
                    bool isIn = chatList.Contains(message);
                    if (isIn)
                    {
                        chatList.Remove(message);
                    }
                }
                else if (com == "Edit")
                {
                    string old = comandArgs[1];
                    string news = comandArgs[2];
                    int index = chatList.IndexOf(old);
                    chatList.RemoveAt(index);
                    chatList.Insert(index, news);

                }
                else if (com == "Pin")
                {
                    string message = comandArgs[1];
                    chatList.Remove(message);
                    chatList.Add(message);

                }
                else if (com == "Spam")
                {
                    for (int i = 1; i < comandArgs.Length; i++)
                    {
                        chatList.Add(comandArgs[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine,chatList));


        }
    }
}
