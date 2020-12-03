using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class CircleMarkUp/*:IMarkUp*/
    {
        public List<PointF> PointList
        {
            get
            {
                return PointList;
            }
            private set
            {
                PointList = value;
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
            //Some calculations
            return PointList.ToArray();
        }
    }
}
