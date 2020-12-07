using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class HandMarkUp : IMarkUp
    {
        public List<PointF> PointList { get; set; }
        public int Length
        {
            get
            {
                return PointList.Count;
            }
        }

        public PointF StartPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public HandMarkUp()
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
            throw new NotImplementedException();
        }
    }
}
