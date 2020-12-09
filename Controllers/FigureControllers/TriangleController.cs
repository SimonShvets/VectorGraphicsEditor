using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class TriangleController: IFigureController
    {
        private bool _mouseDown = true;
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (figure.Length == 0)
            {
                figure.StartPoint = point;
                figure.Markup.Add(figure.StartPoint);
            }
            else
            {
                figure.Update(point);
            }
            if (figure.Length == 2)
            {
                figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
            }
            else if (figure.Length == 3)
            {
                canvas.Graphics.DrawLine(pen, figure.StartPoint, point);
                figure.EndPoint = point;
            }
            _mouseDown = true;
            canvas.Save();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

            if (_mouseDown == false && figure.Length > 0 && figure.Length < 3)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, figure.Markup[figure.Length - 1], point);
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }
    }
}
