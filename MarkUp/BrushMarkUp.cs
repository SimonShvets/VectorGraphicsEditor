using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public class BrushMarkUp:IMarkUp
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
        public BrushMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {            
            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            StartPoint = endPoint;
            PointList.Add(StartPoint);
        }
    }
}
