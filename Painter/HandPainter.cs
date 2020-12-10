using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class HandPainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            
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