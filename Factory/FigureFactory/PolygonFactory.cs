using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class PolygonFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new PolygonFigure(new PolygonPainter(), new PolygonController());
        }
    }
}
