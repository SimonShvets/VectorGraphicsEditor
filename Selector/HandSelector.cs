using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Selector
{
    public class HandSelector: AbstractSelector
    {
        //перегрузка метода Select для Rotate
        public bool Select(PointF checkPoint, double accuracy)
        {
            return true;
        }

        // Перегрузка метода Select для Resize

        public bool Select(double accuracy)
        {
            throw new NotImplementedException();
        }
    }
}
