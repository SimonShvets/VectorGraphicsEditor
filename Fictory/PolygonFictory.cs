using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class PolygonFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new PolygonController();
        }

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
