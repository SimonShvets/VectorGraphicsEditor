using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class TriangleFigure : AbstractFigure
    {
        public TriangleFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            if (Points.Count < 4)
            {
                Points.Add(point);
                return Points.ToArray();
            }
            else
            {
                Points = new List<PointF>();
                Points.Add(point);
                return Points.ToArray();
            }
        }
    }
}
