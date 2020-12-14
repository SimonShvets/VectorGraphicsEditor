using System.Drawing;
using VectorGraphicsEditor.Figure;


namespace VectorGraphicsEditor.Controllers
{
    public interface IFigureController
    {
        void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas);
        void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas);
        void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas);
        void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas);
    }
}
