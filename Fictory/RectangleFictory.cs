using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class RectangleFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new RectangleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new RectanglePainter();
        }
    }
}
