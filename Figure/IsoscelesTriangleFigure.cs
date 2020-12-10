using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class IsoscelesTriangleFigure : AbstractFigure
    {
        public IsoscelesTriangleFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }

        public override void Update(PointF endPoint)
        {
            Markup = new List<PointF>
            {
                new PointF((int)StartPoint.X, (int)StartPoint.Y),
                new PointF((int)endPoint.X, (int)endPoint.Y),
                new PointF((int)endPoint.X - ((int)endPoint.X - (int)StartPoint.X)*2, (int)endPoint.Y)
            };
        }
    }
}
