using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Layouts
{
   public interface ILayoutFactory
    {
        ILayout CreateLayout(string layout);
    }
}
