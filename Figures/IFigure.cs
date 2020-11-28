using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Figures
{
    public interface IFigure
    {
        void DrawFigure(Pen pen, Graphics graphics, PointList pointList);
    }
}
