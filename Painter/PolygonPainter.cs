using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public class PolygonPainter : IPainter
    {
        private bool _mouseDown = false;
        public PointF[] res;

        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            graphics.DrawPolygon(pen, points);
        }

        public void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            _mouseDown = true;
            markUp.StartPoint = point;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            if (_mouseDown)
            {
                markUp.Update(point);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                DrawFigure(pen, canvas.Graphics, markUp.Calculate());
                //res = markUp.Calculate();
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
        {
            //markUp.PointList.Clear();
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas)
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
