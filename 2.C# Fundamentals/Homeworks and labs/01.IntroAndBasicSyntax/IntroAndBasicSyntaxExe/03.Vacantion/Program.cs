using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string person = Console.ReadLine();
            string weekDay = Console.ReadLine();

            double price = 0.0;
            double sumPrice = 0.0;
            if (weekDay == "Friday")
            {
                if (person == "Students")
                {
                    price = 8.45;
                }
                else if (person == "Business")
                {
                    price = 10.90;
                }
                else if (person == "Regular")
                {
                    price = 15;
                }

            }
            else if (weekDay == "Saturday")
            {
                if (person == "Students")
                {
                    price = 9.80;
                }
                else if (person == "Business")
                {
                    price = 15.60;
                }
                else if (person == "Regular")
                {
                    price = 20;
                }
            }
            else if (weekDay == "Sunday")
            {
                if (person == "Students")
                {
                    price = 10.46;
                }
                else if (person == "Business")
                {
                    price = 16;
                }
                else if (person == "Regular")
                {
                    price = 22.50;
                }
            }
            sumPrice = price;
            price *= peopleNum;

            if (person== "Students" && peopleNum >= 30)
            {
                price *= 0.85;
            }
            else if (person == "Business" && peopleNum >= 100)
            {
                price -= (10 *sumPrice );
            }
            else if (person == "Regular" && peopleNum >= 10 && peopleNum <=20 )
            {
                price *= 0.95;
            }

            Console.WriteLine($"Total price: {price:f2}");




        }
    }
}
