using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class CurveMarkUp: IMarkUp
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
        public CurveMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            PointList.Add(endPoint);
        }
        public PointF[] CalculateFrame()
        {
            //float radius = StartPoint.Y - CircleStartPoint.Y;
            PointF[] p = new PointF[]
            {

            };
            return p;
        }
        public PointF[] Vertex(PointF i)
        {
            PointF[] node = new PointF[]
            {
            };
            return node;
        }
    }
}
