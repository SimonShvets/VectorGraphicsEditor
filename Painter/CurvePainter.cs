using System.Drawing;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Painter
{
    public class CurvePainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLines(pen, points);
        }
    }
}
