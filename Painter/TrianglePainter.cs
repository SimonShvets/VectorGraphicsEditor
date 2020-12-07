using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class TrianglePainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLine(pen, points[points.Length - 2], points[points.Length - 1]);
        }
    }
}
