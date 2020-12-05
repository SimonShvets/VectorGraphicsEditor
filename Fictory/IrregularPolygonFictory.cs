using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class IrregularPolygonFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new IrregularPolygonMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new IrregularPolygonPainter();
        }
    }
}
