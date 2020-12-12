using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class TriangleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new TriangleFigure(new TrianglePainter(), new TriangleController());
        }
    }
}
