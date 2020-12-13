using System.Drawing;
using System.Drawing.Drawing2D;
namespace VectorGraphicsEditor.Painter
{
    public class IrregularPolygonPainter: IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path)
        {
            graphics.DrawPolygon(pen, path.PathPoints);
        }
    }
}
