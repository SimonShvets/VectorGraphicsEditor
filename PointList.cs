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
        public int Length
        {
            get
            {
                return _listOfPoints.Count;
            }
        }
        public PointF this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _listOfPoints[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _listOfPoints[index] = value;
            }
        }
        public PointList()
        {
            _listOfPoints = new List<PointF>();
        }
        public PointList(int length)
        {
            PointF[] points = new PointF[length];
            Array.Copy(points, _listOfPoints.ToArray(), length);
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
