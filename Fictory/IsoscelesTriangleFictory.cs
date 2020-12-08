using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class IsoscelesTriangleFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new IsoscelesTriangleController();
        }

        public IMarkUp CreateMarkUp()
        {
            return new IsoscelesTriangleMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new IsoscelesTrianglePainter();
        }
    }
}
