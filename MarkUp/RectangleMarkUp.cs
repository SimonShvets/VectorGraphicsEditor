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

        public RectangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            return PointList.ToArray();
        }
        public void Update(PointF endPoint)
        {
            PointList = new List<PointF>
            {
                StartPoint,
                new PointF(StartPoint.X, endPoint.Y),
                endPoint,
                new PointF(endPoint.X, StartPoint.Y)
            };
        }
    }
}
