using System;
using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Controllers
{
    public class PolygonController: IFigureController
    {
        private bool _mouseDown = false;
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            canvas.Graphics.Dispose();
            _mouseDown = true;
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

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

        }

        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
    }
}
