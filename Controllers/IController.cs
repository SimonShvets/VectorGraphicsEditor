using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;


namespace VectorGraphicsEditor.Controllers
{
    public interface IController
    {
        void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas);
        void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas);
        void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas);
        void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas);
        void KeyDown();
        void KeyUp();
    }
}
