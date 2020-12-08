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
        public PointF StartPoint { get; set; }
        public int Length
        {
            get
            {
                return PointList.Count;
            }
        }
        public ElipseMarkUp()
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
                new PointF(StartPoint.X, endPoint.Y),
                new PointF(StartPoint.Y, endPoint.Y),
                new PointF(endPoint.X - StartPoint.X , endPoint.Y),
                new PointF(endPoint.Y - StartPoint.Y, endPoint.Y)
            };
        }
    }
}
