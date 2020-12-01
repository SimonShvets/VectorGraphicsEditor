using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class HandMarkUp : IMarkUp
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
        public HandMarkUp()
        {
        }
        public PointList Calculate(PointList pointList)
        {
            throw new NotImplementedException();
        }
    }
}
