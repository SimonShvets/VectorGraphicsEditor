using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class RightTriangleFigure : AbstractFigure
    {
        public RightTriangleFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Calculate()
        {
            PointF[] points = new PointF[3] 
            {
                Markup[0],
                Markup[1], 
                new PointF(Markup[0].X, Markup[1].Y) 
            };
            return points;
        }

        public override void Update(PointF endPoint)
        {
            Markup = new List<PointF>
            {
                StartPoint,
                endPoint,
                new PointF(StartPoint.X, endPoint.Y)
            };
        }
    }
}
