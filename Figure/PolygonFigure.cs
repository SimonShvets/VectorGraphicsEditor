using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class PolygonFigure: AbstractFigure
    {
        public int N { get; set; }
        public override List<PointF> Markup { get; set; }
        public override PointF StartPoint { get; set; }
        public override PointF EndPoint { get; set; }
        public override int Length
        {
            get
            {
                return Markup.Count;
            }
        }
        public PolygonFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override PointF[] Calculate()
        {

            return Markup.ToArray();
        }

        public override void Update(PointF endPoint)
        {
            if (N > 2)
            {
                PointF PolygonStartPoint = new PointF(StartPoint.X, endPoint.Y);
                Markup = new List<PointF>
            {
                PolygonStartPoint
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
                    int x = (int)StartPoint.X;
                }
            }
        }
    }
}
