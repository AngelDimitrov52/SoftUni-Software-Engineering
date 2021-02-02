using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person pesrson = new Person("Pesho", 20);

            Console.WriteLine(pesrson.Name + " " + pesrson.Age);
        }
    }
}
