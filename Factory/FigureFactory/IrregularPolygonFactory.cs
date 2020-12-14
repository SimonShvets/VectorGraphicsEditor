using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class IrregularPolygonFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IFigureController figureController)
        {
            return new IrregularPolygonFigure(new IrregularPolygonController());
        }
    }
}
