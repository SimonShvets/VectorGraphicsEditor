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
        PointF[] points1;
        public List<PointF> PointList { get; set; }
        public int Length
        {
            get
            {
                return PointList.Count;
            }
            set
            {
            }
        }
        public PolygonMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            if (N > 2)
            {
                points1 = new PointF[N];
                points1[0] = new PointF(PointList[0].X, PointList[1].Y);
                int a = 360 / N;
                float t;
                for (int i = 1; i < N; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((PointList[0].X - (points1[0].Y - PointList[0].Y) * Math.Sin(rad)));
                    float y1 = (float)((PointList[0].Y + (points1[0].Y - PointList[0].Y) * Math.Cos(rad)));
                    points1[i] = new PointF(x1, y1);
                }
            }
            return points1;
        }
    }
}
