using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class PolygonPainter : IPainter
    {
        public int N { get; set; }

        PointF[] points1;

        public PolygonPainter(int n)
        {
            N = n;
        }

        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
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

        public void StateOn()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void StateOff()
        {
            throw new NotImplementedException();
        }

        public void StateFixed()
        {
            throw new NotImplementedException();
        }
    }
}
