using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class CurveFictory : IFictory
    {
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
