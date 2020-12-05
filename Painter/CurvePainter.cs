using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public class CurvePainter: IPainter
    {
        private bool _mouseDown = true;
        private bool _mouseDoubleDown = false;
        public PointF[] res;
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
            if (_mouseDoubleDown == false)
            {
            markUp.AddPoint(point);
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            if (markUp.Length != 1)
            {
                DrawFigure(pen, canvas.Graphics, markUp.Calculate());
            }
            canvas.Save();
            GC.Collect();
            }
            _mouseDown = true;
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                canvas.Graphics.DrawLine(pen, markUp.Calculate()[markUp.Length - 1], point);
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            res = markUp.Calculate();
            _mouseDown = false;
            _mouseDoubleDown = true;
            canvas.Save();
        }
    }
}
