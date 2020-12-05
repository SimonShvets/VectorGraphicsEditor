using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class ElipseMarkUp : IMarkUp
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
        public ElipseMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            PointF[] result = new PointF[4];
            result[0].X = PointList[0].X;
            result[1].X = PointList[0].Y;
            result[2].X = PointList[1].X - PointList[0].X;
            result[3].X = PointList[1].Y - PointList[0].Y;
            return result;
        }
    }
}
