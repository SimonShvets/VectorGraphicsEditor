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
            int x = (int)PointList[0].X;
            int y = (int)PointList[0].Y;
            int x2 = (int)PointList[1].X;
            int x1 = (x2 - x);
            PointF[] result = new PointF[3];
            result[0].X = x - x1;
            result[1].X = y - x1;
            result[2].X = x1 * 2;
            return result;
        }
    }
}
