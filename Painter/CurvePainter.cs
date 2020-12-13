using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace VectorGraphicsEditor.Painter
{
    public class CurvePainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path)
        {
            graphics.DrawPath(pen, path);
        }
    }
}
