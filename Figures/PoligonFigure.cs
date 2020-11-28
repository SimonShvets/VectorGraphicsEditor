using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class PolygonFigure : IFigure
    {
        public int N { get; set; }
        PointF[] points1;

        public PolygonFigure(int n)
        {
            N = n;
        }

        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            
            if (N > 2)
            {
                points1 = new PointF[N];
                points1[0] = new PointF(pointList[0].X, pointList[1].Y);
                int a = 360 / N;
                float t;
                for (int i = 1; i < N; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((pointList[0].X - (points1[0].Y - pointList[0].Y) * Math.Sin(rad)));
                    float y1 = (float)((pointList[0].Y + (points1[0].Y - pointList[0].Y) * Math.Cos(rad)));
                    points1[i] = new PointF(x1, y1);
                }
            }
            graphics.DrawPolygon(pen, points1);
        }
    }
}
