using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Telephony
{
    class StationaryPhone : ICall
    {
        public string Call(string numbers)
        {
            foreach (var element in numbers)
            {
                if (!char.IsDigit(element))
                {
                    return $"Invalid number!";
                }
            }

            return $"Dialing... {numbers}";

        }
    }
}
