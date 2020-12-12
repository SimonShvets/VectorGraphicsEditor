using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class CircleController: IFigureController
    {
        private bool _mouseDown = false;
        public void KeyDown()
        {

        }

        public void KeyUp()
        {

        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            canvas.Graphics.Dispose();
            figure.StartPoint = point;
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (_mouseDown)
            {
                figure.Update(point);
                canvas.CreateLayer();
                figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
                figure.EndPoint = point;
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.SaveLayer();
        }
    }
}
