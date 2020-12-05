using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class SquareFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new SquareMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new SquarePainter();
        }
    }
}
