using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public interface IToolController
    {
        void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures);
        void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures);
        void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures);
        void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures);
        void KeyDown();
        void KeyUp();
    }
}
