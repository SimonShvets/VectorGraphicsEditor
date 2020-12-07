using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class CurveController: IController
    {
        private bool _mouseDown = true;
        private bool _mouseDoubleDown = false;
        public PointF[] res;
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (_mouseDoubleDown == false)
            {
                markUp.Update(point);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                if (markUp.Length != 1)
                {
                    painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                }
                canvas.Save();
                GC.Collect();
            }
            _mouseDown = true;
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, markUp.StartPoint, point);
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            res = markUp.Calculate();
            markUp.PointList.Clear();
            _mouseDown = false;
            _mouseDoubleDown = true;
            canvas.Save();
        }
    }
}
