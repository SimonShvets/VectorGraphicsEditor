using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class PolygonMarkUp/* : IMarkUp*/
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
        public PolygonMarkUp()
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
