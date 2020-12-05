using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class IrregularPolygonMarkUp: IMarkUp
    {
        public List<PointF> PointList { get; set; }
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

        public IrregularPolygonMarkUp()
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
