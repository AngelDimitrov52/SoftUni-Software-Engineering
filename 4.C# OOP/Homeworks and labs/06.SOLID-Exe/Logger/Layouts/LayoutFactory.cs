using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Layouts
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string layout)
        {
            ILayout newLayout = null;
            if (layout == nameof(SimpleLayout))
            {
                newLayout = new SimpleLayout();
            }
            else if (layout == nameof(XmlLayout))
            {
                newLayout = new XmlLayout();
            }
            return newLayout;
        }
    }
}
