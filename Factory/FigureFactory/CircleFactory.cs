using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class CircleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new CircleFigure(new CirclePainter(), new CircleController());
        }
    }
}
