using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class IsoscelesTriangleFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new IsoscelesTriangleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new IsoscelesTrianglePainter();
        }
    }
}
