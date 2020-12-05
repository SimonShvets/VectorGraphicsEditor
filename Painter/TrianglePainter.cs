using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public class TrianglePainter: IPainter
    {
        private bool _mouseDown = true;
        private void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLine(pen, points[points.Length - 2], points[points.Length - 1]);
        }

        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            markUp.AddPoint(point);
            if (markUp.Length == 2)
            {
                DrawFigure(pen, canvas.Graphics, markUp.Calculate());
            }
            else if (markUp.Length == 3)
            {
                canvas.Graphics.DrawLine(pen, markUp.Calculate()[0], markUp.Calculate()[2]);
            }
            _mouseDown = true;
            canvas.Save();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {

            if (_mouseDown == false && markUp.Length > 0 && markUp.Length < 3)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, markUp.Calculate()[markUp.Length - 1], point);
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }
    }
}
