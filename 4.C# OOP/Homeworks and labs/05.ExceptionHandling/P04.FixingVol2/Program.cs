using System;

namespace P04.FixingVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine($"{num1} x {num2} = {result}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"OverflowException - the sum must be in range of type of {nameof(result)}");
                Console.WriteLine( "Please chenge the numbers.");
            }

            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            result = Convert.ToByte(num1 * num2);
            Console.WriteLine($"{num1} x {num2} = {result}");
        }
    }
}
