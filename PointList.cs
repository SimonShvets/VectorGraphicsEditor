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
        public int Lenght { get; private set; } = 0;
        public PointList()
        {
            _listOfPoints = new List<PointF>();
        }
        public void AddPoint(PointF point)
        {
            _listOfPoints.Add(point);
            Lenght++;
        }
        public PointF [] ConvertToPointF()
        {
            PointF[] points = new PointF[Lenght];
            int k = 0;
            foreach (PointF i in _listOfPoints)
            {
                points[k] = i;
                k++;
            }
            return points;
        }
    }
}
