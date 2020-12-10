using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class PolygonMarkUp: IMarkUp
    {
        public int N { get; set; }
        public List<PointF> PointList { get; set; }
        public PointF StartPoint { get; set; }
        PointF PolygonStartPoint;
        public int Length
        {
            get
            {
                return PointList.Count;
            }
        }
        public PolygonMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {

            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            if (N > 2)
            {
                PolygonStartPoint = new PointF(StartPoint.X, endPoint.Y);
                PointList = new List<PointF>
                {
                    PolygonStartPoint
                };
                int a = 360 / N;
                float t;
                for (int i = 1; i < N; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((StartPoint.X - (endPoint.Y - StartPoint.Y) * Math.Sin(rad)));
                    float y1 = (float)((StartPoint.Y + (endPoint.Y - StartPoint.Y) * Math.Cos(rad)));
                    PointF point = new PointF(x1, y1);
                    PointList.Add(point);
                    int x = (int)StartPoint.X;
                }
            }
        }
        public PointF[] CalculateFrame()
        {
            float maxX = 0;
            float referenceY = StartPoint.Y;
            foreach (PointF point in Calculate())
            {
                if (PolygonStartPoint.Y < StartPoint.Y)
                {
                    if (point.Y > referenceY)
                    {
                        referenceY = point.Y;
                    }
                }
                else
                {
                    if (point.Y < referenceY)
                    {
                        referenceY = point.Y;
                    }
                }
                if (point.X > maxX)
                {
                    maxX = point.X;
                }
            }
            PointF[] p = new PointF[]
            {
                PolygonStartPoint,
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, PolygonStartPoint.Y),
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, PolygonStartPoint.Y + (referenceY - PolygonStartPoint.Y)/2),
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, referenceY),
                new PointF(PolygonStartPoint.X, referenceY),
                new PointF(maxX, referenceY),
                new PointF(maxX, PolygonStartPoint.Y + (referenceY - PolygonStartPoint.Y)/2),
                new PointF(maxX, PolygonStartPoint.Y)
            };
            return p;
        }

        public PointF[] Vertex(PointF i)
        {
            PointF[] node = new PointF[]
            {
                new PointF(i.X - 4, i.Y-4),
                new PointF(i.X - 4, i.Y+4),
                new PointF(i.X + 4, i.Y+4),
                new PointF(i.X + 4, i.Y-4)
            };
            return node;
        }


    }
}
