using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class IsoscelesTriangleMarkUp : IMarkUp
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
        public IsoscelesTriangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            int x = (int)PointList[0].X;
            int y = (int)PointList[0].Y;
            int x2 = (int)PointList[1].X;
            int y2 = (int)PointList[1].Y;
            PointF[] points = new PointF[3];
            points[0] = PointList[0];
            points[1] = PointList[1];
            points[2] = new Point((x2 - (x2 - x) * 2), y2);

            return points;
        }
    }
}
