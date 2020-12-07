using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Fictory
{
    public interface IFictory
    {
        IMarkUp CreateMarkUp();
        IPainter CreatePainter();
        IController CreateController();

    }
}
