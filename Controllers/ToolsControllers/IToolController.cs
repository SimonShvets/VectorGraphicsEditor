using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;


namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public interface IToolController
    {
        void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool);
        void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool);
        void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool);
        void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool);
        void KeyDown();
        void KeyUp();
    }
}
