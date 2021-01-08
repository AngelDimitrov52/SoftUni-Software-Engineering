using System;

namespace FlowerHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numFlower = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;
      // &quot; Roses & quot;, &quot; Dahlias & quot;, &quot; Tulips & quot;, &quot; Narcissus & quot;, &quot; Gladiolus & quot;
            //  Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            // Ако Нели купи повече от 90 Далии - 15 % отстъпка от крайната цена
            // Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            // Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            // Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %
            if (flower == "Roses")
            {
                price = 5;
                if (numFlower> 80)
                {
                    price = price * 0.90;

                }

            }
            else if (flower == "Dahlias")
            {
                price = 3.80;
                if (numFlower > 90)
                {
                    price = price * 0.85;

                }

            }
            else if (flower == "Tulips")
            {
                price = 2.80;
                if (numFlower > 80)
                {
                    price = price * 0.85;

                }

            }
            else if (flower == "Narcissus")
            {
                price = 3;
                if (numFlower < 120)
                {
                    price = price * 1.15;

                }

            }
            else if (flower == "Gladiolus")
            {
                price = 2.50;
                if (numFlower < 80)
                {
                    price = price * 1.20;

                }

            }
            double total = numFlower * price;

            if (budget >=total)
            {
                double a = budget - total;
                Console.WriteLine($"Hey, you have a great garden with {numFlower} {flower} and {a:f2} leva left.");
            }
            else
            {
                double a = total - budget;
                Console.WriteLine($"Not enough money, you need {a:f2} leva more.");
            }


        }
    }
}
