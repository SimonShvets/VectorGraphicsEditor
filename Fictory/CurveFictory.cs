using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class CurveFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new CurveController();
        }

        public IMarkUp CreateMarkUp()
        {
            return new CurveMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new CurvePainter();
        }
    }
}
