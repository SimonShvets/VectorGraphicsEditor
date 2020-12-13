using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Painter
{
    public interface IPainter
    {
        void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path);
    }
}
