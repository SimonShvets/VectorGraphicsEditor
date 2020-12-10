using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public interface IFigureFactory
    {
        AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController);
    }
}
