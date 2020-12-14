using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Selector
{
    public abstract class AbstractSelector
    {
        public virtual bool Select(AbstractFigure figure, PointF checkpoint)
        {
            return figure.Markup.IsVisible(checkpoint);
        }
    }
}
