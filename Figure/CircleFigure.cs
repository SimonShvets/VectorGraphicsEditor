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
        public CircleFigure(IPainter painter, IFigureController figureController)
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
        //int y = (int)PointList[0].Y;
        //int x2 = (int)PointList[1].X;
        //int x1 = (x2 - x);
        //PointF[] result = new PointF[4];
        //result[0].X = x - x1;
        //result[1].X = y - x1;
        //result[2].X = x1 * 2;
        //result[3].X = x1 * 2;
        //return result;
    }
}
