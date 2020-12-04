using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Painter
{
    public class BrushPainter : IPainter
    {
        private bool _mouseDown = false;
        private void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawLines(pen, points);
        }

        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(MouseEventArgs e, Pen pen, IMarkUp markUp, Canvas canvas)
        {
        }

        public void MouseDownHandle(MouseEventArgs e, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = true;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            markUp.AddPoint(e.Location);
        }

        public void MouseMoveHandle(MouseEventArgs e, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            if (_mouseDown)
            {
                markUp.AddPoint(e.Location);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                DrawFigure(pen, canvas.Graphics, markUp.Calculate());
            }
        }

        public void MouseUpHandle(MouseEventArgs e, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = false;
        }
    }
}
