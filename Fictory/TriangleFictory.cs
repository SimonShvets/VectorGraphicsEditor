using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class TriangleFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new TriangleController();
        }

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
