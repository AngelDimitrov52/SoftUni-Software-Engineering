using SOLID.Enums;
using SOLID.Appernders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appender;

        public Logger(params IAppender[] appender)
        {
            this.appender = appender;
        }

        public void Error(string data, string message)
        {
            AppendToAppenders(data, ReportLevel.Error, message);
        }

        public void Info(string data, string message)
        {
            AppendToAppenders(data, ReportLevel.Info, message);
        }
        public void Critical(string data, string message)
        {
            AppendToAppenders(data, ReportLevel.Critical, message);
        }
        public void Fatal(string data, string message)
        {
            AppendToAppenders(data, ReportLevel.Fatal, message);
        }
        public void Warning(string data, string message)
        {
            AppendToAppenders(data, ReportLevel.Warning, message);
        }

        private void AppendToAppenders(string data, ReportLevel level, string message)
        {
            foreach (var item in appender)
            {
                item.Append(data, level, message);
            }

        }
    }
}
