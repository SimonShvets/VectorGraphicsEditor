using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class RectangleMarkUp : IMarkUp
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
        public RectangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            PointList.Add(point);
        }
        public PointF[] Calculate()
        {
            PointF[] points1 = new PointF[4]
            { 
                PointList[0], 
                new PointF(PointList[0].X, PointList[1].Y), 
                PointList[1], 
                new PointF(PointList[1].X, PointList[0].Y) 
            };
            return points1;
        }
    }
}
