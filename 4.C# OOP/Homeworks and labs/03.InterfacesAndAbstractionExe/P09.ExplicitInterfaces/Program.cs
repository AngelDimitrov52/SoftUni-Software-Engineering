using System;

namespace P09.ExplicitInterfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            string comand;
            while ((comand= Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split();

                string name = comandArgs[0];
                string country = comandArgs[1];
                int age = int.Parse(comandArgs[2]);

                Citizen person = new Citizen(name, country, age);

                IResident resident = person;
                IPerson iperson = person;

                Console.WriteLine(iperson.GetName());
                Console.WriteLine($"{resident.GetName()}{iperson.GetName()}");
            }

        }
    }
}
