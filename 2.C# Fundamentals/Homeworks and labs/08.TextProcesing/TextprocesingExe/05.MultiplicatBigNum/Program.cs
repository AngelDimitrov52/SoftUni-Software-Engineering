using System;
using System.Text;
using System.Linq;

namespace _05.MultiplicatBigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine().TrimStart('0');
            int num = int.Parse(Console.ReadLine());
            if (bigNumber == "" || num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sum = new StringBuilder();
            int plus = 0;
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                
                int digit = int.Parse(bigNumber[i].ToString());
                int mid = digit * num;
                mid += plus;
                plus = 0;
                int ostatuk = 0;
                if (mid > 9)
                {
                    ostatuk = mid % 10;
                    mid /= 10;

                    sum.Insert(0,ostatuk);

                    plus = mid;
                    if (i ==0 )
                    {
                        sum.Insert(0, plus);
                    }
                }
                else
                {
                    sum.Insert(0,mid);
                }

            }
            Console.WriteLine(sum.ToString());





        }
    }
}
