using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using VectorGraphicsEditor.Selector;

namespace VectorGraphicsEditor.Tools
{
    public class Clear: AbstractTool
    {
        public Clear(AbstractSelector clearSelector)
        {
            Selector = clearSelector;
        }
        public void changeColor(Color color, Pen pen, MouseEventArgs e, Bitmap Bmp)
        {
            color = Bmp.GetPixel(e.Location.X, e.Location.Y);
            pen.Color = color;            
        } 
    }
}
