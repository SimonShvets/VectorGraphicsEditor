using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class IsoscelesTriangleFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            PointF[] points = new PointF[3];
           
                points[0] = new PointF(pointList[0].X, pointList[1].Y);
                int a = 360 / 3;
                float t;
                for (int i = 1; i < 3; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((pointList[0].X - (points[0].Y - pointList[0].Y) * Math.Sin(rad)));
                    float y1 = (float)((pointList[0].Y + (points[0].Y - pointList[0].Y) * Math.Cos(rad)));
                    points[i] = new PointF(x1, y1);
                }
            
            graphics.DrawPolygon(pen, points);            

        }
    }
}
