using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Bear bear = new Bear("Bear");
            string ad = bear.Name;
            Console.WriteLine(ad);
        }
    }
}