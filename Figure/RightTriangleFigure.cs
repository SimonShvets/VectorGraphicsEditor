using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class RightTriangleFigure : AbstractFigure
    {
        public RightTriangleFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            Points = new List<PointF>
            {
                StartPoint ,
                point,
                new PointF(StartPoint .X, point.Y)
            };
            return Points.ToArray();
        }
    }
}
