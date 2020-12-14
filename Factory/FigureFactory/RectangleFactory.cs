using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class RectangleFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IFigureController figureController)
        {
            return new RectangleFigure(new RectangleController());
        }
    }
}
