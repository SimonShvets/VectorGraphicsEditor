using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class SquareFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            PointF[] points = new PointF[4];
            int x = (int)pointList[0].X;
            int y = (int)pointList[0].Y;
            int x2 = (int)pointList[1].X;
           // int y2 = (int)pointList[1].Y;
            int a = Math.Abs(x2 - x);
           // int b = Math.Abs(y2 - y);
            //int c = a + b;
            points[0] = pointList[0];
            //points[1] = new PointF(pointList[0].X, pointList[1].Y + a);
            //points[2] = pointList[1];
            //points[3] = new PointF(pointList[1].X + a, pointList[0].Y);
            points[1] = new PointF(x, y + a);
            points[2] = new PointF(x + a, y + a);
            points[3] = new PointF(x + a, y);
            graphics.DrawPolygon(pen, points);
            
        }
    }
}
