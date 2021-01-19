using System;

namespace _06.Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "unknown";

            if (country == "USA")
            {
                language = "English";
            }
            else if (country == "England")
            {
                language = "English";
            }
            else if (country == "Spain")
            {
                language = "Spanish ";
            }
            else if (country == "Argentina ")
            {
                language = "Spanish ";
            }
            else if (country == "Mexico")
            {
                language = "Spanish ";
            }


            Console.WriteLine(language);






        }
    }
}
