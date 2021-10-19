using System;
using System.Collections.Generic;
using System.IO;

namespace _04.MargeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            using (StreamReader readerOne = new StreamReader("../../../FileOne.txt"))
            {
                string firstLine = readerOne.ReadLine();

                using (StreamReader readerTwo = new StreamReader("../../../FileTwo.txt"))
                {
                    string secondLine = readerTwo.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        nums.Add(int.Parse(firstLine));
                        nums.Add(int.Parse(secondLine));
                        firstLine = readerOne.ReadLine();
                        secondLine = readerTwo.ReadLine();
                    }
                }
            }
            nums.Sort();
            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                foreach (var item in nums)
                {
                    writer.WriteLine(item);
                }
            }
        }
    }
}
