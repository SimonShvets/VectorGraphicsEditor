﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class SquareFigure : AbstractFigure
    {
        public SquareFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }

        public override void Update(PointF endPoint)
        {
            int x = (int)StartPoint.X;
            int y = (int)StartPoint.Y;
            int x2 = (int)endPoint.X;
            int y2 = (int)endPoint.Y;
            //int a = Math.Abs(x2 - x);
            //int b = Math.Abs(y2 - y);
            int a = Math.Abs(x - x2);

            if (y > y2)
            {
                a = -a;
            }


            Markup = new List<PointF>
            {
                new PointF(x, y),
                new PointF(x, y + a),
                new PointF(x2, y + a),
                new PointF(x2, y),
            };
        }
    }
}
