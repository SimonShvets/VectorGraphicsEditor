using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class IrregularPolygonFigure : AbstractFigure
    {
        public IrregularPolygonFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            Points.Add(point);
            return Points.ToArray();
        }
    }
}
