using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class BrushPainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLines(pen, points);
        }
    }
}
