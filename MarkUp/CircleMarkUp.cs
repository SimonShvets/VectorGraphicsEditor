using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class CircleMarkUp: IMarkUp
    {
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
        private int N = 90;

        public CircleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            PointF[] points1 = new PointF[N];
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
                int x = (int)PointList[0].X;
            }
            return points1;
            //int y = (int)PointList[0].Y;
            //int x2 = (int)PointList[1].X;
            //int x1 = (x2 - x);
            //PointF[] result = new PointF[4];
            //result[0].X = x - x1;
            //result[1].X = y - x1;
            //result[2].X = x1 * 2;
            //result[3].X = x1 * 2;
            //return result;
        }
    }
}
