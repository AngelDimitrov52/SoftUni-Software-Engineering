using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("../../../words.txt"))
            {
                string[] word = reader.ReadLine().Split();
                foreach (var item in word)
                {
                    words.Add(item.ToLower(), 0);
                }
                using (StreamReader readline = new StreamReader("../../../text.txt"))
                {
                    string line = readline.ReadLine();
                    while (line != null)
                    {
                        foreach (var item in word)
                        {
                            if (line.ToLower().Contains(item))
                            {
                                words[item]++;
                            }
                        }

                        line = readline.ReadLine();
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                foreach (var item in words.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }

            }
        }
    }
}
