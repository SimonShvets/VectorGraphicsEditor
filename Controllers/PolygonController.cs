using System;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Controllers
{
    public class PolygonController: IController
    {
        private bool _mouseDown = false;
        public PointF[] res;
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
                //res = markUp.Calculate();
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
        {
            //markUp.PointList.Clear();
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, IPainter painter, Canvas canvas)
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
