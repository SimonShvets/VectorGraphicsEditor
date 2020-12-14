using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;

namespace VectorGraphicsEditor.Factory.FigureFactory
{
    public class CurveFactory : IFigureFactory
    {
        public AbstractFigure CreateFigure(IFigureController figureController)
        {
            return new CurveFigure(new CurveController());
        }
    }
}
