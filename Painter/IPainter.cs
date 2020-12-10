using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Painter
{
    public interface IPainter
    {
        void DrawFigure(Pen pen, Graphics graphics, PointF[] points);
        void DrawFrame(Pen pen, Graphics graphics, PointF[] points);
        void DrawVertex(Pen pen, Graphics graphics, PointF[] points);
    }
}
