using System;

namespace _04.TrekingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int musala = 0;
            int monblan = 0;
            int kimimandjaro = 0;
            int k2 = 0;
            int everest = 0;


            for (int i = 1; i <= groups; i++)
            {
                int groupsNum = int.Parse(Console.ReadLine());
                if (groupsNum > 40)
                {
                    everest += groupsNum;
                }
                else if (groupsNum > 25)
                {
                    k2 += groupsNum;
                }
                else if (groupsNum > 12)
                {
                    kimimandjaro += groupsNum;
                }
                else if (groupsNum > 5)
                {
                    monblan += groupsNum;
                }
                else
                {
                    musala += groupsNum;
                }
            }
            int total = musala + monblan + kimimandjaro + k2 + everest;
            Console.WriteLine($"{musala*1.0 / total*100:f2}%");
            Console.WriteLine($"{monblan*1.0 / total*100:f2}%");
            Console.WriteLine($"{kimimandjaro*1.0 / total*100:f2}%");
            Console.WriteLine($"{k2*1.0 / total*100:f2}%");
            Console.WriteLine($"{everest*1.0 / total*100:f2}%");
            
        }
    }
}
