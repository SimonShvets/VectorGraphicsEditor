using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class CircleFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new CircleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new CirclePainter();
        }
        public IController CreateController()
        {
            return new CircleController();
        }
    }
}
