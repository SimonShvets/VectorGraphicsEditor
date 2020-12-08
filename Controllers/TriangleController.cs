using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class TriangleController: IController
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
        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp,IPainter painter, Canvas canvas)
        {
            if (markUp.Length == 0)
            {
                markUp.StartPoint = point;
                markUp.PointList.Add(markUp.StartPoint);
            }
            else
            {
                markUp.Update(point);
            }
            if (markUp.Length == 2)
            {
                painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
            }
            else if (markUp.Length == 3)
            {
                canvas.Graphics.DrawLine(pen, markUp.StartPoint, markUp.Calculate()[2]);
            }
            _mouseDown = true;
            canvas.Save();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {

            if (_mouseDown == false && markUp.Length > 0 && markUp.Length < 3)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, markUp.PointList[markUp.Length - 1], point);
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }
    }
}
