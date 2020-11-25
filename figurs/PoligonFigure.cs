using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.figurs
{
    public class PolygonFigure : IFigure
    {
        int n;
        PointF[] points1;

        public PolygonFigure(int n)
        {
            this.n = n;
        }

        public Bitmap DrawFigure(Graphics graphics, Bitmap bitmap, PointF[] points, Pen pen)
        {
            if (n > 2)
            {
                points1 = new PointF[n];
                points1[0] = new PointF(points[0].X, points[1].Y);
                int a = 360 / n;
                float t;
                for (int i = 1; i < n; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((points[0].X - (points1[0].Y - points[0].Y) * Math.Sin(rad)));
                    float y1 = (float)((points[0].Y + (points1[0].Y - points[0].Y) * Math.Cos(rad)));
                    points1[i] = new PointF(x1, y1);
                }
            }

            graphics.DrawPolygon(pen, points1);
            return bitmap;
        }

        private PointF[] GetPoints(PointF[] points)
        {
            return points;
        }
    }
}
