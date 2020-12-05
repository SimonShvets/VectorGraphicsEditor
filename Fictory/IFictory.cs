using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Fictory
{
    public interface IFictory
    {
        IMarkUp CreateMarkUp();
        IPainter CreatePainter();
    }
}
