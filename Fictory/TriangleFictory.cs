using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class TriangleFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new TriangleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new TrianglePainter();
        }
    }
}
