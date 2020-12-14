using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class SquareFigure : AbstractFigure
    {
        public SquareFigure(IFigureController figureController)
        {
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            int x = (int)StartPoint.X;
            int y = (int)StartPoint.Y;
            int x2 = (int)point.X;
            int y2 = (int)point.Y;
            int a = Math.Abs(x - x2);
            if (y > y2)
            {
                a = -a;
            }
            Points = new List<PointF>
            {
                new PointF(x, y),
                new PointF(x, y + a),
                new PointF(x2, y + a),
                new PointF(x2, y),
            };
            return Points.ToArray();
        }

    }
}
