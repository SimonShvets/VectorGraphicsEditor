using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Selector
{
    public class PipetteSelector: AbstractSelector
    {
        public bool Select(Color color, Pen pen, MouseEventArgs e, Bitmap bmp)
        {
            return true;
        }        
    }
}
