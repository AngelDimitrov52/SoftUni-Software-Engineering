using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Loggers
{
    public interface ILogger
    {
        void Error(string data , string message);
        void Info(string data , string message);
        void Critical(string data , string message);
        void Fatal(string data , string message);
        void Warning(string data , string message);
    }
}
