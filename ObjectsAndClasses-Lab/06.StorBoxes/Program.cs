using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StorBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            List<Box> boxList = new List<Box>();

            while (comand != "end")
            {
                string[] comandArgr = comand.Split();
                string serialNum = comandArgr[0];
                string item = comandArgr[1];
                int itemQuantity = int.Parse(comandArgr[2]);
                double priceForABox = double.Parse(comandArgr[3]);
                double totalSum = priceForABox * itemQuantity;

                Box itemFinal = new Box(serialNum, item, itemQuantity, priceForABox, totalSum);

                boxList.Add(itemFinal);

                comand = Console.ReadLine();
            }
            List<Box> SortedList = boxList.OrderBy(o => o.TotalSum).ToList();
            SortedList.Reverse();
            foreach (Box item in SortedList)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item} - ${ item.PriceForABox:f2}: { item.ItemQuantity}");
                Console.WriteLine($"-- ${item.TotalSum:f2}"); 


            }
        }

    }


    class Box
    {


        public Box(string serialNumber, string item, int itemQuantity, double priceForABox,double totalSum)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForABox = priceForABox;
            TotalSum = totalSum;
        }

        public string SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
        public double TotalSum { get; set; }

    }
}
