using SOLID.Enums;
using SOLID.Appernders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
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
            foreach (var item in appenders)
            {
                item.Append(data, level, message);
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in appenders)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
