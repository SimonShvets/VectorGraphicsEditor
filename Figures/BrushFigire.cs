using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class BrushFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            graphics.DrawLine(pen, pointList.ConvertToPointF()[pointList.Length - 2 ], pointList.ConvertToPointF()[pointList.Length - 1]);
        }
    }
}
