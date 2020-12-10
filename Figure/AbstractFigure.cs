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

    }
}
