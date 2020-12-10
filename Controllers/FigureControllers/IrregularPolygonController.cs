using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;
using System.Windows.Forms;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class IrregularPolygonController: IFigureController
    {
        private bool _mouseDown = true;
        private bool _mouseDoubleDown = false;
        Pen pen1 = new Pen(Color.Blue, 1);
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (_mouseDoubleDown == false)
            {
                if (figure.Length == 0)
                {
                    figure.StartPoint = point;
                    figure.Markup.Add(figure.StartPoint);
                }
                else
                {
                    figure.Update(point);
                }
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                if (figure.Length != 1)
                {
                    figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
                }
                canvas.Save();
                GC.Collect();
            }
            _mouseDown = true;
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                if (figure.Length != 0)
                {
                    canvas.Graphics.DrawLine(pen, figure.Markup[figure.Length - 1], point);
                }
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.Save();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            _mouseDoubleDown = true;
            canvas.Graphics.DrawLine(pen, figure.Calculate()[0], figure.Calculate()[figure.Length - 1]);
            figure.EndPoint = point;
            canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
            canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
            figure.Painter.DrawFrame(pen1, canvas.Graphics, figure.CalculateFrame());
            foreach (PointF i in figure.CalculateFrame())
            {
                figure.Painter.DrawVertex(pen1, canvas.Graphics, figure.Vertex(i));
            }
            GC.Collect();
            canvas.Save();
        }
    }
}
