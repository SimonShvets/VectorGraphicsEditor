using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class BrushController: IFigureController
    {
        private bool _mouseDown = false;
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            canvas.Graphics.Dispose();
            figure.StartPoint = point;
            figure.Update(point);
            canvas.CreateLayer();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        { 
            if (_mouseDown)
            {
                figure.Update(point);
                canvas.Graphics.DrawLine(pen, figure.Calculate()[figure.Calculate().Length - 2], figure.Calculate()[figure.Calculate().Length - 1]);
                figure.EndPoint = point;
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            if (figure.Markup.Count > 1)
            {
            figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
            }
            canvas.SaveLayer();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
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
