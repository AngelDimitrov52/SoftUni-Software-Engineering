using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] stringArr = ArrayCreator.Create(5, "Angel");
            int[] intArr = ArrayCreator.Create(6, 17);

        }
    }
}
