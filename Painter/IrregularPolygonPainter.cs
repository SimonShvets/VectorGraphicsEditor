using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class IrregularPolygonPainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLine(pen, points[points.Length - 2], points[points.Length - 1]);
        }
        public void DrawFrame(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
        public void DrawVertex(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
