using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class SquareMarkUp : IMarkUp
    {
        public List<PointF> PointList { get; set; }

       // List<PointF> IMarkUp.PointList { get; set ; }
        public int Length { get; set; }

        public SquareMarkUp()
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
            int a = Math.Abs(x2 - x);
            int b = Math.Abs(y2 - y);
            PointF[] points = new PointF[4];
            points[0] = new PointF(x, y);
            points[1] = new PointF(x, y2 + a);
            points[2] = new PointF(x2 + b, y2 + a);
            points[3] = new PointF(x2 + b, y);
            return points;
        }
    }
}
