using System;

namespace _05.MountPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int mountNum = int.Parse(Console.ReadLine());
            if (mountNum >=13||mountNum<=0)
            {
                Console.WriteLine("Error!");
                return;
            }
            string[] mountname = new string[] 
            { "January",   
   "February",    
"March",
   "April" ,  
   "May", 
   "June",    
   "July",    
   "August",
   "September",   
  "October",
  "November",    
  "December"};
            Console.WriteLine(mountname[mountNum-1]);
        }
    }
}
