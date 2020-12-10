using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class CircleFigure : AbstractFigure
    {
        private int N = 90;
        public CircleFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override void Update(PointF endPoint)
        {
            PointF CircleStartPoint = new PointF(StartPoint.X, endPoint.Y);
            Markup = new List<PointF>
            {
                CircleStartPoint
            };
            int a = 360 / N;    
            float t;
            for (int i = 1; i < N; i++)
            {
                t = a * i;
                float rad = (float)(Math.PI / 180.0 * t);
                float x1 = (float)((StartPoint.X - (endPoint.Y - StartPoint.Y) * Math.Sin(rad)));
                float y1 = (float)((StartPoint.Y + (endPoint.Y - StartPoint.Y) * Math.Cos(rad)));
                PointF point = new PointF(x1, y1);
                Markup.Add(point);
            }
        }
    }
}
