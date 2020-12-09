using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public abstract class AbstractFigure
    {
        public abstract List<PointF> Markup { get; set; }
        public abstract PointF StartPoint { get; set; }
        public abstract PointF EndPoint { get; set; }
        public IPainter Painter { get; protected set; }
        public IFigureController FigureController { get; protected set; }
        public abstract int Length { get; }
        public AbstractFigure()
        {
            Markup = new List<PointF>();
        }
        public abstract PointF[] Calculate();
        public abstract void Update(PointF endPoint);

    }
}
