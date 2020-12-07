using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class SquareFictory : IFictory
    {
        public IController CreateController()
        {
           return new SquareController();
        }

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
