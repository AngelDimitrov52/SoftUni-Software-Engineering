using SOLID.Enums;
using SOLID.Appernders;
using SOLID.Layouts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SOLID.Loggers;

namespace SOLID.Appernders
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string data, ReportLevel level, string message)
        {
            if (level < ReportLevel)
            {
                return;
            }
            MessageCout++;
            string append = string.Format(layout.Template, data, level, message) + Environment.NewLine;

            logFile.Write(append);
        }
        public override string ToString()
        {
            return base.ToString() + $", File size: {logFile.Size}";
        }
    }
}
