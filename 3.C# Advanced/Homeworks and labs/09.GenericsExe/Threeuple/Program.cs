using System;
using System.Collections.Generic;
using System.Linq;

namespace Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] personAdress = Console.ReadLine().Split();
            string name = $"{personAdress[0]} {personAdress[1]}";
            string addres = personAdress[2];
            List<string> towns = personAdress.Skip(3).ToList();
            string town = string.Join(" ", towns);
            Threeuple<string, string, string> NameTuple =
                new Threeuple<string, string, string>(name, addres , town);

            string[] person = Console.ReadLine().Split();
            name = person[0];
            int age = int.Parse(person[1]);
             bool isDrung = person[2] == "drunk" ? true : false;
            Threeuple<string, int , bool> personTuple =
                new Threeuple<string, int ,bool>(name, age , isDrung);

            string[] nums = Console.ReadLine().Split();
            string intNum = nums[0];
            double doubleNum = double.Parse(nums[1]);
            string bank = nums[2];
            Threeuple<string, double , string> numsTuple =
                new Threeuple<string, double , string>(intNum, doubleNum ,bank);

            Console.WriteLine(NameTuple);
            Console.WriteLine(personTuple);
            Console.WriteLine(numsTuple);

        }
    }
}
