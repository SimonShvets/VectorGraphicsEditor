using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class RectangleFictory : IFictory
    {
        public IController CreateController()
        {
            return new RectangleController();
        }

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
