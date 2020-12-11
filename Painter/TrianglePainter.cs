using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class TrianglePainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLines(pen, points);
            graphics.DrawLine(pen, points[0], points[2]);
        }
    }
}
