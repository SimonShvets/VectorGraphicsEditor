using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class IrregularPolygonFigure : AbstractFigure
    {
        public IrregularPolygonFigure(IFigureController figureController)
        {
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            Points.Add(point);
            return Points.ToArray();
        }
    }
}
