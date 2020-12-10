using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class CircleController: IFigureController
    {
        private bool _mouseDown = false;
        Pen pen1 = new Pen(Color.Blue, 1);
        public void KeyDown()
        {

        }

        public void KeyUp()
        {

        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            figure.StartPoint = point;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (_mouseDown)
            {
                figure.Update(point);
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                figure.EndPoint = point;
                figure.Painter.DrawFigure(pen1, canvas.Graphics, figure.Calculate());
                
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            figure.EndPoint = point;
            figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
            figure.Painter.DrawFrame(pen1, canvas.Graphics, figure.CalculateFrame());
            foreach(PointF i in figure.CalculateFrame())
            {
                figure.Painter.DrawVertex(pen1, canvas.Graphics, figure.Vertex(i));
            }
            GC.Collect();
            canvas.Save();
        }
    }
}
