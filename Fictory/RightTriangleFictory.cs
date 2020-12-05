using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class RightTriangleFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new RightTriangleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new RightTrianglePainter();
        }
    }
}
