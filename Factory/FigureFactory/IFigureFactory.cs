using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure(IFigureController figureController);
    }
}
