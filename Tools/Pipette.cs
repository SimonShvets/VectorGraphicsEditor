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
    public class Pipette: AbstractTool
    {        
        public Pipette(AbstractSelector pipetteSelector)
        {
            Selector = pipetteSelector;
        }
        public void changeColor(Color color, Pen pen, PointF point, Canvas canvas)
        {           
            color = canvas.MainBitmap.GetPixel((int)point.X, (int)point.Y);            
            pen.Color = color;                 
        } 
    }
}
