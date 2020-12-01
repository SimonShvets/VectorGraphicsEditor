using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class RectangleMarkUp : IMarkUp
    {
        public PointList Marks
        { 
            get
            {
                return Marks;
            }
            set
            {

            }
        }
        public RectangleMarkUp()
        {
        }

        public PointList Calculate(PointList pointList)
        {
            return pointList;
        }
    }
}
