using SOLID.Enums;
using SOLID.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appernders
{
    public interface IAppender
    {
        public ReportLevel ReportLevel { get; set; }
        void Append(string data, ReportLevel level, string message);
    }
}
