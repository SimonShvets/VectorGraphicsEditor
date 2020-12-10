using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class RectangleController: IFigureController
    {
        private bool _mouseDown = false;
        Pen pen1 = new Pen(Color.Blue, 1);
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            figure.StartPoint = point;
            _mouseDown = true;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (_mouseDown)
            {
                figure.Update(point);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
                figure.EndPoint = point;
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
            painter.DrawFrame(pen1, canvas.Graphics, markUp.CalculateFrame());
            foreach (PointF i in markUp.CalculateFrame())
            {
                painter.DrawVertex(pen1, canvas.Graphics, markUp.Vertex(i));
            }
            GC.Collect();
            canvas.Save();
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
