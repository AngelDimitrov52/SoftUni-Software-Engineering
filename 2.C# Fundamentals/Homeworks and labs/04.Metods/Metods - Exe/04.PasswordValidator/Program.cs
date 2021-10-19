using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();



            bool lenght = IsPasswordIsToLonng(password);
            bool leterAndDigir = IsPasswordHaveOnlyLeterAndDigit(password);
            bool moreThanTwo = IsPasswordHaveMoreThanTwoDigits(password); 

            if (lenght && leterAndDigir && moreThanTwo)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            if (!lenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!leterAndDigir)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!moreThanTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool IsPasswordHaveMoreThanTwoDigits(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
            }
            if (counter>=2)
            {
                return true;
            }
            return false;
        }

        private static bool IsPasswordHaveOnlyLeterAndDigit(string password)
        {
            bool result = password.All(Char.IsLetterOrDigit);
            if (result == true)
            {
                return true;
            }
            return false; 

        }

        private static bool IsPasswordIsToLonng(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }
            return true;
        }
    }
}
