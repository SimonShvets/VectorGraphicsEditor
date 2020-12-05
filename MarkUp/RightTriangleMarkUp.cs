using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class RightTriangleMarkUp: IMarkUp
    {
        public List<PointF> PointList { get; set; }
        public int Length { get; set; }

        public RightTriangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            PointF[] points = new PointF[3] { PointList[0], PointList[1], new PointF(PointList[0].X, PointList[1].Y) };
            return points;
        }
    }
}
