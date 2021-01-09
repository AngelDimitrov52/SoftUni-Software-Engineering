using System;

namespace _01.FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrase =
            {
                "Excellent product.",
                "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events =
            {
                     "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
             };
            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            Random rnd = new Random();


            for (int i = 0; i < n; i++)
            {
                int text1 = rnd.Next(0, phrase.Length);
                int text2 = rnd.Next(0, events.Length);
                int text3 = rnd.Next(0, authors.Length);
                int text4 = rnd.Next(0, cities.Length);
                Console.WriteLine($"{phrase[text1]} {events[text2]} {authors[text3]} - {cities[text4]}.");

            }



        }
    }
}
