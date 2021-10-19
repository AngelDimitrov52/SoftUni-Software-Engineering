using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Eat();
            Dog buki = new Dog();
            buki.Eat();
            buki.Bark();

        }
    }
}
