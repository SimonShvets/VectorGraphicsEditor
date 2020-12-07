using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class ElipsePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            Rectangle rect = new Rectangle((int)points[0].X, (int)points[1].X, (int)points[2].X, (int)points[3].X);
            graphics.DrawEllipse(pen, rect);
        }
    }
}
