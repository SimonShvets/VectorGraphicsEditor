using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class IsoscelesTriangleFigure : AbstractFigure
    {
        public IsoscelesTriangleFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            Points = new List<PointF>
            {
                new PointF((int)StartPoint .X, (int)StartPoint .Y),
                new PointF((int)point.X, (int)point.Y),
                new PointF((int)point.X - ((int)point.X - (int)StartPoint .X)*2, (int)point.Y)
            };
            return Points.ToArray();
        }
    }
}
