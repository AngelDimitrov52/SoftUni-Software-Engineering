using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> nums = new EqualityScale<int>(2, 2);
            Console.WriteLine(nums.AreEqual());
        }
    }
}
