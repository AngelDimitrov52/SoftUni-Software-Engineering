using System;

namespace P05.ConvertToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringNum = Console.ReadLine();
            try
            {
                double doubleNum = Convert.ToDouble(stringNum);

            }
            catch (FormatException ex)
            {

                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
