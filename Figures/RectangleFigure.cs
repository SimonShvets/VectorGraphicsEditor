using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class RectangleFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {

            PointF[] points1 = new PointF[4] { pointList[0], new PointF(pointList[0].X, pointList[1].Y), pointList[1], new PointF(pointList[1].X, pointList[0].Y) };
            graphics.DrawPolygon(pen, points1);
        }
    }
}
