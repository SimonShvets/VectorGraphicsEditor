using System;
using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class CircleMarkUp: IMarkUp
    {
        public List<PointF> PointList { get; set; }
        public PointF[] Points
        {
            get
            {
                return PointList.ToArray();
            }
        }
        public PointF StartPoint { get; set; }
        public int Length
        {
            get
            {
                return PointList.Count;
            }
        }
        private int N = 90;
        public CircleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            PointF CircleStartPoint = new PointF(StartPoint.X, endPoint.Y);
            PointList = new List<PointF>
            {
                CircleStartPoint
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
            }
        }

        public void MarkUp()
        {

        }
    }
}
