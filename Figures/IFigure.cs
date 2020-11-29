using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public interface IFigure
    {
        void DrawFigure(Pen pen, Graphics graphics, PointList pointList);
    }
}
