using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class IrregularPolygonPainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLines(pen, points);
            graphics.DrawLine(pen, points[0], points[points.Length-1]);
        }
    }
}
