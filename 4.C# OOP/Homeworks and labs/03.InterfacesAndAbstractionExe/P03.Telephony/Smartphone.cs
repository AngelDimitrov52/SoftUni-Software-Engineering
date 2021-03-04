using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Telephony
{
    public class Smartphone : ICall, IBrowsing
    {

        public string Browsing(string web)
        {
            foreach (var element in web)
            {
                if (char.IsDigit(element))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {web}!";

        }

        public string Call(string numbers)
        {
            foreach (var element in numbers)
            {
                if (!char.IsDigit(element))
                {
                    return $"Invalid number!";
                }
            }

            return $"Calling... {numbers}";

        }
    }
}





