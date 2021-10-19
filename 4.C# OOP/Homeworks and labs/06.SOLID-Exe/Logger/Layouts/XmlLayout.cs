using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Template =>   "<log >" + Environment.NewLine +
    "   <date > {0} PM</date>" + Environment.NewLine +
    "   <level>{1}</level>" + Environment.NewLine +
    "   <message>{2}</message>" + Environment.NewLine +
  "</log>";

    }
}
