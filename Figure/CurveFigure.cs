using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class CurveFigure: AbstractFigure
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
        public CurveFigure(IPainter painter, IFigureController figureController)
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
            Markup.Add(endPoint);
        }
    }
}
