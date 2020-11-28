using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor
{
    public class PointList
    {
        private List<PointF> _listOfPoints;
        public int Lenght
        {
            get
            {
                return _listOfPoints.Count;
            }
        }
        public PointList()
        {
            _listOfPoints = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            _listOfPoints.Add(point);
        }
        public PointF [] ConvertToPointF()
        {
            return _listOfPoints.ToArray(); 
        }
    }
}
