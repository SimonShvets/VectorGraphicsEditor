using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class RightTriangleFictory : IFictory
    {
        public IController CreateController()
        {
            return new RectangleController();
        }

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
