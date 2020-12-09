using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class IsoscelesTriangleFigure : AbstractFigure
    {
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
        public IsoscelesTriangleFigure(IPainter painter, IFigureController figureController)
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
            Markup = new List<PointF>
            {
                new PointF((int)StartPoint.X, (int)StartPoint.Y),
                new PointF((int)endPoint.X, (int)endPoint.Y),
                new PointF((int)endPoint.X - ((int)endPoint.X - (int)StartPoint.X)*2, (int)endPoint.Y)
            };
            //int x = (int)PointList[0].X;
            //int y = (int)PointList[0].Y;
            //int x2 = (int)PointList[1].X;
            //int y2 = (int)PointList[1].Y;
            //PointF[] points = new PointF[3];
            //points[0] = PointList[0];
            //points[1] = PointList[1];
            //points[2] = new Point((x2 - (x2 - x) * 2), y2);
        }
    }
}
