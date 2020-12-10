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
<<<<<<< HEAD:MarkUp/PolygonMarkUp.cs
        public List<PointF> PointList { get; set; }
        public PointF StartPoint { get; set; }
        PointF PolygonStartPoint;
        public int Length
=======
        public PolygonFigure(IPainter painter, IFigureController figureController)
>>>>>>> NewArchitecture:Figure/PolygonFigure.cs
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }
        public override void Update(PointF endPoint)
        {
            if (N > 2)
            {
<<<<<<< HEAD:MarkUp/PolygonMarkUp.cs
                PolygonStartPoint = new PointF(StartPoint.X, endPoint.Y);
                PointList = new List<PointF>
                {
                    PolygonStartPoint
                };
=======
                PointF PolygonStartPoint = new PointF(StartPoint.X, endPoint.Y);
                Markup = new List<PointF>
            {
                PolygonStartPoint
            };
>>>>>>> NewArchitecture:Figure/PolygonFigure.cs
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
        public PointF[] CalculateFrame()
        {
            float maxX = 0;
            float referenceY = StartPoint.Y;
            foreach (PointF point in Calculate())
            {
                if (PolygonStartPoint.Y < StartPoint.Y)
                {
                    if (point.Y > referenceY)
                    {
                        referenceY = point.Y;
                    }
                }
                else
                {
                    if (point.Y < referenceY)
                    {
                        referenceY = point.Y;
                    }
                }
                if (point.X > maxX)
                {
                    maxX = point.X;
                }
            }
            PointF[] p = new PointF[]
            {
                PolygonStartPoint,
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, PolygonStartPoint.Y),
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, PolygonStartPoint.Y + (referenceY - PolygonStartPoint.Y)/2),
                new PointF(maxX - (maxX - PolygonStartPoint.X)*2, referenceY),
                new PointF(PolygonStartPoint.X, referenceY),
                new PointF(maxX, referenceY),
                new PointF(maxX, PolygonStartPoint.Y + (referenceY - PolygonStartPoint.Y)/2),
                new PointF(maxX, PolygonStartPoint.Y)
            };
            return p;
        }

        public PointF[] Vertex(PointF i)
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
