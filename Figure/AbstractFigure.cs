using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Controllers;
using System.Drawing.Drawing2D;
using System;

namespace VectorGraphicsEditor.Figure
{
    public abstract class AbstractFigure
    {
        public GraphicsPath Markup { get; set; }
        public PointF StartPoint { get; set; }
        public List<PointF> Points { get; set; }
        public IFigureController FigureController { get; protected set; }
        public AbstractFigure()
        {
            Markup = new GraphicsPath();
            Points = new List<PointF>();
        }
        public abstract PointF[] Update(PointF point);
    }
}
