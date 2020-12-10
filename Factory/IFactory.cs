using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Factory
{
    public interface IFactory
    {
        AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController);
    }
}
