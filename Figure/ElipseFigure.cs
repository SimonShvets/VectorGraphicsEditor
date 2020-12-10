using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class ElipseFigure : AbstractFigure
    {
        public ElipseFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }

        public override void Update(PointF endPoint)
        {
            Markup = new List<PointF>
            {
                new PointF(StartPoint.X, endPoint.Y),
                new PointF(StartPoint.Y, endPoint.Y),
                new PointF(endPoint.X - StartPoint.X , endPoint.Y),
                new PointF(endPoint.Y - StartPoint.Y, endPoint.Y)
            };
        }

        public override PointF[] CalculateFrame()
        {
            PointF[] points = Calculate();
            PointF[] p = new PointF[]
            {
                new PointF(points[0].X, points[1].X),
                new PointF(points[0].X, points[1].X + ((points[1].X + points[3].X) - points[1].X)/2),
                new PointF(points[0].X, (points[1].X + points[3].X)),
                new PointF(points[0].X + ((points[0].X + points[2].X) - points[0].X)/2, (points[1].X + points[3].X)),
                new PointF(points[0].X + points[2].X,points[1].X + points[3].X),
                new PointF(points[0].X + points[2].X, points[1].X + ((points[1].X + points[3].X) - points[1].X)/2),
                new PointF(points[0].X + points[2].X,points[1].X),
                new PointF(points[0].X + ((points[0].X + points[2].X) - points[0].X)/2, points[1].X),
            };
            return p;
        }

        public override PointF[] Vertex(PointF i)
        {
            PointF[] node = new PointF[]
            {
                new PointF(i.X - 4, i.Y-4),
                new PointF(i.X - 4, i.Y+4),
                new PointF(i.X + 4, i.Y+4),
                new PointF(i.X + 4, i.Y-4)
            };
            return node;
        }
    }
}
