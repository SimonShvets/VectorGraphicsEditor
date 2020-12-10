﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class RectangleFigure : AbstractFigure
    {
        public RectangleFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override void Update(PointF endPoint)
        {
            Markup = new List<PointF>
            {
                StartPoint,
                new PointF(StartPoint.X, endPoint.Y),
                endPoint,
                new PointF(endPoint.X, StartPoint.Y)
            };
        }
        public PointF[] CalculateFrame()
        {
            //float radius = StartPoint.Y - CircleStartPoint.Y;
            PointF[] p = new PointF[]
            {

            };
            return p;
        }
        public PointF[] Vertex(PointF i)
        {
            PointF[] node = new PointF[]
            {
            };
            return node;
        }
    }
}