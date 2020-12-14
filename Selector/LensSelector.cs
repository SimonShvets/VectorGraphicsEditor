using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Selector
{
    public class LensSelector: AbstractSelector
    {
        public bool Select(Canvas canvas, PointF point)
        {
            return true;
        }        
    }
}
