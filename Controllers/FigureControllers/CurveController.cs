using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class CurveController: IFigureController
    {
        private bool _mouseDown = true;
        private bool _mouseDoubleDown = false;
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
            _mouseDown = true;
            if (_mouseDoubleDown == false)
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
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                if (markUp.Length != 1)
                {
                    painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                }
                canvas.Save();
                GC.Collect();
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, markUp.PointList[markUp.Length-1], point);
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
            _mouseDown = false;
            _mouseDoubleDown = true;
            canvas.Save();
        }
    }
}
