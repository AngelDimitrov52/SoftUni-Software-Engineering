using SOLID.Enums;
using SOLID.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Appernders
{
    public interface IApenderFactory
    {
        IAppender CreateAppender(string apendertype , ILayout layout , ReportLevel reportLevel);
    }
}
