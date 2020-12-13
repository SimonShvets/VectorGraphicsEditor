using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class ElipseFigure : AbstractFigure
    {
        public ElipseFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }

        public override PointF[] Update(PointF point)
        {
            Points = new List<PointF>
            {
                StartPoint,
                new PointF(StartPoint.X, point.Y),
                point,
                new PointF(point.X, StartPoint.Y)
            };
            return Points.ToArray();
        }
    }
}
