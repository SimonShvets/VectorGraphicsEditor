using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class IrregularPolygonFictory : IFictory
    {
        public IController CreateController()
        {
            return new IrregularPolygonController();
        }

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
