using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class CircleFigure : AbstractFigure
    {
        private int N = 90;
        public CircleFigure(IFigureController figureController)
        {
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            PointF CircleStartPoint = new PointF(StartPoint.X, point.Y);
            Points = new List<PointF> { CircleStartPoint };
            int a = 360 / N;    
            float t;
            for (int i = 1; i < N; i++)
            {
                t = a * i;
                float rad = (float)(Math.PI / 180.0 * t);
                float x1 = (float)((StartPoint.X - (point.Y - StartPoint.Y) * Math.Sin(rad)));
                float y1 = (float)((StartPoint.Y + (point.Y - StartPoint.Y) * Math.Cos(rad)));
                PointF CirclePoint = new PointF(x1, y1);
                Points.Add(CirclePoint);
            }
            return Points.ToArray();
        }
    }
}
