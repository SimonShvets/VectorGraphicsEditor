﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class RectangleFigure : AbstractFigure
    {
        public RectangleFigure(IFigureController figureController)
        {
            FigureController = figureController;
        }
        public override PointF[] Update(PointF endPoint)
        {
            Points = new List<PointF>
            {
                StartPoint,
                new PointF(StartPoint .X, endPoint.Y),
                endPoint,
                new PointF(endPoint.X, StartPoint .Y)
            };
            return Points.ToArray();
        }
    }
}
