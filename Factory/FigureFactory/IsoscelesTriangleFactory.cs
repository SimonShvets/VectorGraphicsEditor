using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class IsoscelesTriangleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new IsoscelesTriangleFigure(new IsoscelesTrianglePainter(), new IsoscelesTriangleController());
        }
    }
}
