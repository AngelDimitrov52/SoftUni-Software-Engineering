using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type;
            while ((type = Console.ReadLine()) != "Beast!")
            {
                string comand = Console.ReadLine();

                var comandArgs = comand.Split();
                var name = comandArgs[0];
                var age = int.Parse(comandArgs[1]);
                var gender = comandArgs[2];

                if (name == "" || age < 0 || gender == "")
                {
                    Console.WriteLine("Invalid input!");
                }

                if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog.ToString());
                    dog.ProduceSound();
                }
                else if (type == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat.ToString());
                    cat.ProduceSound();
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog.ToString());
                    frog.ProduceSound();
                }
                else if (type == "Kittens")
                {
                    Kitten kit = new Kitten(name, age);
                    Console.WriteLine(kit.ToString());
                    kit.ProduceSound();

                }
                else if (type == "Tomcat")
                {
                    Tomcat tom = new Tomcat(name, age);
                    Console.WriteLine(tom.ToString());
                    tom.ProduceSound();
                }

            }
        }
    }
}
