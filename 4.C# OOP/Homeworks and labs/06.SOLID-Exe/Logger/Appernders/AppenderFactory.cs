using SOLID.Enums;
using SOLID.Layouts;
using SOLID.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appernders
{
    public class AppenderFactory : IApenderFactory
    {
        public IAppender CreateAppender(string apendertype, ILayout layout, ReportLevel reportLevel)
        {
            IAppender apender = null;
            if (apendertype == nameof(ConsoleAppender))
            {
                apender = new ConsoleAppender(layout);
                apender.ReportLevel = reportLevel;
            }
            else if (apendertype == nameof(FileAppender))
            {
                apender = new FileAppender(layout , new LogFile());
                apender.ReportLevel = reportLevel;
            }
            return apender;
        }
    }
}
