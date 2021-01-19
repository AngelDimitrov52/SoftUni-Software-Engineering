using System;

namespace _07.VendingMashine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coin = Console.ReadLine();
            double parsCoin = 0.0;
            double sumCoin = 0.0;

            while (coin != "Start")
            {
                parsCoin = double.Parse(coin);
                switch (parsCoin)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sumCoin += parsCoin;
                        break;

                    default:
                        Console.WriteLine($"Cannot accept {parsCoin}");
                        break;
                }
                coin = Console.ReadLine();
            }
            string comand = Console.ReadLine();
            while (comand != "End")
            {
                double produktPrice = 0.0;
                if (comand == "Nuts")
                {
                  
                    produktPrice = 2.0;
                   
                }
                else if (comand=="Water")
                {
                    produktPrice= 0.7;
                  
                }
                else if (comand=="Crisps")
                {
                   
                    produktPrice= 1.5;
                
                }
                else if (comand=="Soda")
                {
                 
                    produktPrice= 0.8;
                    
                }
                else if (comand=="Coke")
                {
             
                    produktPrice= 1.0;
                  
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    
                }
                if (sumCoin >= produktPrice)
                {
                    if (comand == "Nuts"|| comand == "Water" || comand == "Crisps" || comand == "Soda" || comand == "Coke")
                    {

                    sumCoin -= produktPrice;
                    Console.WriteLine($"Purchased {comand.ToLower()}");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }


                comand = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoin:f2}");
            
        }
    }
}
