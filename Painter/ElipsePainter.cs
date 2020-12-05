using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public class ElipsePainter : IPainter
    {
        private bool _mouseDown = false;
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            Rectangle rect = new Rectangle((int)points[0].X, (int)points[1].X, (int)points[2].X, (int)points[3].X);
            graphics.DrawEllipse(pen, rect);
        }

        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
        }

        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = true;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            markUp.AddPoint(point);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            if (_mouseDown)
            {
                if (markUp.PointList.Count == 1)
                {
                    markUp.AddPoint(point);
                }
                markUp.PointList[1] = point;
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            markUp.PointList.Clear();
            _mouseDown = false;
            canvas.Save();
        }
    }
}
