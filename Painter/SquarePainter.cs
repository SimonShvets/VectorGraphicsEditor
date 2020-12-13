using System.Drawing;
using System.Drawing.Drawing2D;
namespace VectorGraphicsEditor.Painter
{
    public class SquarePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path)
        {
            graphics.DrawPath(pen, path);
        }
    }
}
