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
        public PointF StartPoint { get; set; }
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
        public RightTriangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            PointF[] points = new PointF[3] 
            { 
                PointList[0], 
                PointList[1], 
                new PointF(PointList[0].X, PointList[1].Y) 
            };
            return points;
        }

        public void Update(PointF endPoint)
        {
            PointList = new List<PointF>
            {
                StartPoint,
                endPoint,
                new PointF(StartPoint.X, endPoint.Y)
            };
        }
    }
}
