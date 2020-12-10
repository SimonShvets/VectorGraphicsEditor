using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class RightTriangleController: IFigureController
    {
        private bool _mouseDown = false;
        Pen pen1 = new Pen(Color.Blue, 1);
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            throw new NotImplementedException();
        }

        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {

            _mouseDown = true;
            markUp.StartPoint = point;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (_mouseDown)
            {
                markUp.Update(point);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
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

    }
}
