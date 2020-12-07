using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public class IsoscelesTrianglePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
