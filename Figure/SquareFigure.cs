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
            throw new NotImplementedException();
        }

        //public override void Update(PointF endPoint)
        //{
        //    int x = (int)StartPoint.X;
        //    int y = (int)StartPoint.Y;
        //    int x2 = (int)endPoint.X;
        //    int y2 = (int)endPoint.Y;
        //    int a = Math.Abs(x2 - x);
        //    int b = Math.Abs(y2 - y);
        //    Markup = new List<PointF>
        //    {
        //         new PointF(x, y),
        //         new PointF(x, y2 + a),
        //         new PointF(x2 + b, y2 + a),
        //         new PointF(x2 + b, y),
        //    };
        //}
    }
}
