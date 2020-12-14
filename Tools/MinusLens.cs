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
    public class MinusLens: AbstractTool
    {        
        public MinusLens(AbstractSelector minusLensSelector)
        {
            Selector = minusLensSelector;
        }
        public void zoom(Canvas canvas, PointF point)
        {           
                const double eps = 1.25;
                double ntX = point.X / eps;
                double ntY = point.Y / eps;
                double dtX = ntX - point.X;
                double dtY = ntY - point.Y;
                canvas.PictureBox.Height = (int)(canvas.PictureBox.Height / eps);
                canvas.PictureBox.Width = canvas.PictureBox.Height + canvas.PictureBox.Height / 3;
                canvas.PictureBox.Location = new Point((int)(canvas.PictureBox.Location.X - dtX), (int)(canvas.PictureBox.Location.Y - dtY));  
            
            //клон битмапа сделать (ректангле задаёт размер)
        }
            

    }
}
