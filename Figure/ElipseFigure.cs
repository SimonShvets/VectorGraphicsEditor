using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class ElipseFigure : AbstractFigure
    {
        public ElipseFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override void Update(PointF endPoint)
        {
            Markup = new List<PointF>
            {
                new PointF(StartPoint.X, endPoint.Y),
                new PointF(StartPoint.Y, endPoint.Y),
                new PointF(endPoint.X - StartPoint.X , endPoint.Y),
                new PointF(endPoint.Y - StartPoint.Y, endPoint.Y)
            };
        }
    }
}
