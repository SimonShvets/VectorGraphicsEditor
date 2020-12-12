using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class RightTriangleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new RightTriangleFigure(new RightTrianglePainter(), new RightTriangleController());
        }
    }
}
