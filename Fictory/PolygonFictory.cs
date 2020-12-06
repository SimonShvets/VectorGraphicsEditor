using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class PolygonFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new PolygonMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new PolygonPainter();
        }
    }
}
