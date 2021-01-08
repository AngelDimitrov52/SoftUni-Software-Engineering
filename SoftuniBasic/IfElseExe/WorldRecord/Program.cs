using System;

namespace WorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldRecord = double.Parse(Console.ReadLine());
            double longMeters = double.Parse(Console.ReadLine());
            double timeSek = double.Parse(Console.ReadLine());

            double slow = Math.Floor(longMeters / 15) * 12.5;

            double total = timeSek * longMeters + slow;

            if (total < oldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {total:f2} seconds.");
            }
            else
            {
                double no = total - oldRecord;
                Console.WriteLine($"No, he failed! He was {no:f2} seconds slower.");
            }
        }
    }
}
