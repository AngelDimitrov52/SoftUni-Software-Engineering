using System;

namespace CharityCampagn
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int confestioner = int.Parse(Console.ReadLine());
            double cake = double.Parse(Console.ReadLine()) * 45;
            double corrugation = double.Parse(Console.ReadLine()) * 5.80;
            double pancake = double.Parse(Console.ReadLine())* 3.20;

            double bill = (cake + corrugation + pancake) * confestioner * day;
            double razhid = bill / 8.0;
            double lastbill = bill - razhid;
            Console.WriteLine($"{lastbill:f2}");
        }
    }
}
