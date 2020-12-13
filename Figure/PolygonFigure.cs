using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Figure
{
    public class PolygonFigure: AbstractFigure
    {
        public int N { get; set; }
        public PolygonFigure(IPainter painter, IFigureController figureController)
        {
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Update(PointF point)
        {
            if (N > 2)
            {
                PointF PolygonStartPoint = new PointF(StartPoint.X, point.Y);
                Points = new List<PointF> { PolygonStartPoint };
                int a = 360 / N;
                float t;
                for (int i = 1; i < N; i++)
                {
                    t = a * i;
                    float rad = (float)(Math.PI / 180.0 * t);
                    float x1 = (float)((StartPoint.X - (point.Y - StartPoint.Y) * Math.Sin(rad)));
                    float y1 = (float)((StartPoint.Y + (point.Y - StartPoint.Y) * Math.Cos(rad)));
                    PointF polygonPoint = new PointF(x1, y1);
                    Points.Add(polygonPoint);
                }
                return Points.ToArray();
            }
            return null;
        }
    }
}
