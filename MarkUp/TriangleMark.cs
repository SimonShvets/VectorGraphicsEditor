using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class TriangleMarkUp: IMarkUp
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
                //??? Уточнить у макса, т к set нужно делать приватным, 
                //но интервейс не позволяет этого сделать
            }
        }
        public TriangleMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            //Some calculations
            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            StartPoint = endPoint;
            PointList.Add(endPoint);
        }
    }
}
