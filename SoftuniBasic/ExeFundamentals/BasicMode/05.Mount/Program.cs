using System;

namespace _05.Mount
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string mount = "Error!";
            switch (day)
            {
                case 1:
                    mount = "January";
                    break;
                case 2:
                    mount = "February";
                    break;
                case 3:
                    mount = "March";
                    break;
                case 4:
                    mount = "April";
                    break;
                case 5:
                    mount = "May";
                    break;
                case 6:
                    mount = "June";
                    break;
                case 7:
                    mount = "July";
                    break;
                case 8:
                    mount = "August";
                    break;
                case 9:
                    mount = "September";
                    break;
                case 10:
                    mount = "October";
                    break;
                case 11:
                    mount = "November";
                    break;
                case 12:
                    mount = "December";
                    break;
                    
               
            }


            Console.WriteLine(mount);
        }
    }
}
