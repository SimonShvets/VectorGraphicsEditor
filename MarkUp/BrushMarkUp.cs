using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class BrushMarkUp
    {
        private List<PointF> _pointList;

        public BrushMarkUp()
        {
            _pointList = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            _pointList.Add(point);
        }
        public PointF[] Calculate()
        {
            //PointF[] point = new PointF[2];
            //point[0] = _pointList[_pointList.Count - 2];
            ////point[1] = _pointList[_pointList.Count - 1];
            //return point;
            return _pointList.ToArray();
        }
    }
}
