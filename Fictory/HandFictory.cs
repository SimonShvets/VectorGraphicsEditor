using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class HandFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new HandController();
        }

        public IMarkUp CreateMarkUp()
        {
            return new HandMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new HandPainter();
        }
    }
}
