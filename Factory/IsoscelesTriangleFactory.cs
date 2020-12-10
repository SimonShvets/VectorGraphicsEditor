using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory
{
    public class IsoscelesTriangleFactory : IFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new IsoscelesTriangleFigure(new IsoscelesTrianglePainter(), new IsoscelesTriangleController());
        }
    }
}
