using SOLID.Enums;
using SOLID.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appernders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) 
            : base(layout)
        {
        }

        public override void Append(string data, ReportLevel level, string message)
        {
            if (level < ReportLevel)
            {
                return;
            }
            MessageCout++;
            string append = string.Format(layout.Template, data, level, message);

            Console.WriteLine(append);
        }
    }
}
