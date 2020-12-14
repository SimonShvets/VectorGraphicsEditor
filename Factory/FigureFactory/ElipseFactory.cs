using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class ElipseFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IFigureController figureController)
        {
            return new ElipseFigure(new ElipseController());
        }
    }
}
