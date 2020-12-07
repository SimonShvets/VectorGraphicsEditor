using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class RectanglePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}

