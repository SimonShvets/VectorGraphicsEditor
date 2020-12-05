using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class HandFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new HandMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new HandPainter();
        }
    }
}
