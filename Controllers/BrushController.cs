using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class BrushController: IController
    {
        private bool _mouseDown = false;
        public PointF[] res;
        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            _mouseDown = true;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            markUp.Update(point);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            if (_mouseDown)
            {
                markUp.Update(point);
                painter.DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            res = markUp.Calculate();
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
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
