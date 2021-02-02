using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person first = new Person();
            Person two = new Person(33);
            Person pesrson = new Person("Pesho", 20);

            Console.WriteLine(first.Name + " " + first.Age);
            Console.WriteLine(two.Name + " " + two.Age);
            Console.WriteLine(pesrson.Name + " " + pesrson.Age);
            
        }
    }
}
