using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class IsoscelesTriangleMarkUp : IMarkUp
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
        public IsoscelesTriangleMarkUp()
        {
        }
        public PointList Calculate(PointList pointList)
        {
            throw new NotImplementedException();
        }
    }
}
