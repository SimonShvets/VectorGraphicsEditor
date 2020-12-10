using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class BrushFigure: AbstractFigure
    {
        public BrushFigure(IPainter painter, IFigureController figureController)
        {
            Markup = new List<PointF>();
            Painter = painter;
            FigureController = figureController;
        }

        public override void Update(PointF endPoint)
        {
            Markup.Add(endPoint);
        }
    }
}
