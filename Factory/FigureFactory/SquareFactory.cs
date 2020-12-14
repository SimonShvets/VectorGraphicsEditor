using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class SquareFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IFigureController figureController)
        {
            return new SquareFigure(new SquareController());
        }
    }
}
