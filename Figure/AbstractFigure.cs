using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public abstract class AbstractFigure
    {
        public List<PointF> Markup { get; set; }
        public PointF StartPoint { get; set; }
        public PointF EndPoint { get; set; }
        public IPainter Painter { get; protected set; }
        public IFigureController FigureController { get; protected set; }
        public int Length
        {
            get
            {
                return Markup.Count;
            }
        }
        public AbstractFigure()
        {
            Markup = new List<PointF>();
        }
        public virtual PointF[] Calculate()
        {
            return Markup.ToArray();
        }
        public abstract void Update(PointF endPoint);

        public virtual PointF[] CalculateFrame()
        {
            float maxX = 0;
            float maxY = 0;
            float minX = StartPoint.X;
            float minY = StartPoint.Y;
            foreach (PointF point in Calculate())
            {
                if (point.Y > maxY)
                {
                    maxY = point.Y;
                }
                if (point.Y < minY)
                {
                    minY = point.Y;
                }
                if (point.X > maxX)
                {
                    maxX = point.X;
                }
                if (point.X < minX)
                {
                    minX = point.X;
                }
            }
            PointF[] p = new PointF[]
            {
                new PointF(maxX,minY),
                new PointF(minX + (maxX - minX)/2,minY),
                new PointF(minX,minY),
                new PointF(minX,minY + (maxY - minY)/2),
                new PointF(minX,maxY),
                new PointF(minX + (maxX - minX)/2,maxY),
                new PointF(maxX,maxY),
                new PointF(maxX,minY + (maxY - minY)/2)
            };
            return p;
        }

        public virtual PointF[] Vertex(PointF i)
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
