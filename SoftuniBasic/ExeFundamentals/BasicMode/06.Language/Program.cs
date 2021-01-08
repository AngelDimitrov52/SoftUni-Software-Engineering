using System;

namespace _06.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            string countri = Console.ReadLine();
            string lang = "unknown";

            if (countri == "USA" || countri == "England")
            {
                lang = "English";
            }
            else if (countri == "Spain" || countri == "Argentina" || countri == "Mexico")
            {
                lang = "Spanish";
            }
            Console.WriteLine(lang);
        }
    }
}
