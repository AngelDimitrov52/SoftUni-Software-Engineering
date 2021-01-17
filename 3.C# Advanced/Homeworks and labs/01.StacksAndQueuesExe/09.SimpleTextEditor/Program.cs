using System;
using System.Collections.Generic;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;

            Stack<string> stackText = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(line[0]);

                switch (command)
                {
                    case 1:
                        string addtext = line[1];
                        text += addtext;
                        stackText.Push(text);
                        break;
                    case 2:
                        int remove = int.Parse(line[1]); ;
                        text = text.Substring(0, text.Length - remove);
                        stackText.Push(text);
                        break;
                    case 3:
                        int index = int.Parse(line[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        stackText.Pop();
                        if (stackText.Count > 0)
                        {
                            text = stackText.Peek();
                        }
                        else
                        {
                            text = string.Empty;
                        }
                        break;
                }
            }
        }
    }
}