using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            
            while (comand != "END")
            {
                bool intTryParseIsSucceess = int.TryParse(comand, out int intValue);
                bool doubleTryParseIsSuccess = double.TryParse(comand, out double doubleValue);
                bool charTryParseIsSuccess = char.TryParse(comand, out char charValue);
                bool boolTryParseIsSuccess = bool.TryParse(comand, out bool boolValue);
                string type = "string";
                if (intTryParseIsSucceess)
                {
                    type = "integer";
                }
                else if (doubleTryParseIsSuccess)
                {
                    type = "floating point";
                }
                else if (boolTryParseIsSuccess)
                {
                    type = "boolean"; 
                }
                else if (charTryParseIsSuccess)
                {
                    type = "character";
                }

                Console.WriteLine($"{comand} is {type} type");
                comand = Console.ReadLine();
            }
        }
    }
}
