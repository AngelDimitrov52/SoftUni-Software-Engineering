using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] personAdress = Console.ReadLine().Split();
            string name = $"{personAdress[0]} {personAdress[1]}";
            string addres = personAdress[2];
            Tuple<string, string> NameTuple = new Tuple<string, string>(name, addres);

            string[] person = Console.ReadLine().Split();
            name = person[0];
            int beer = int.Parse(person[1]);
            Tuple<string, int> personTuple = new Tuple<string, int>(name, beer);

            string[] nums = Console.ReadLine().Split();
            int intNum = int.Parse(nums[0]);
            double doubleNum = double.Parse(nums[1]);
            Tuple<int, double> numsTuple = new Tuple<int, double>(intNum, doubleNum);

            Console.WriteLine(NameTuple);
            Console.WriteLine(personTuple);
            Console.WriteLine(numsTuple);

        }
    }
}
