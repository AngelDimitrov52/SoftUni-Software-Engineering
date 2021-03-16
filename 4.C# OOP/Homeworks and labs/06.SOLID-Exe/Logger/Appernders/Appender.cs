using SOLID.Enums;
using SOLID.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appernders
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel  {get; set;}

        public abstract void Append(string data, ReportLevel level, string message);
       
    }
}
