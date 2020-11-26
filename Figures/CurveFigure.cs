using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Figures
{
    public class CurveFigure : IFigures
    {
        public Bitmap DrawFigure(Pen pen, Graphics graphics, Bitmap tmpBitmap, PointF[] points)
        {
            graphics.DrawLines(pen, points);
            return tmpBitmap;
        }
    }
}
