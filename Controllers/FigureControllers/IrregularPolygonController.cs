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
                GC.Collect();
            }
            _mouseDown = true;
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.CreateLayer();
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
            canvas.SaveLayer();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            _mouseDoubleDown = true;
            if (figure.Markup.Count > 1)
            {
                figure.Painter.DrawFigure(pen, canvas.Graphics, figure.Calculate());
            }
            figure.EndPoint = point;
            canvas.SaveLayer();
            canvas.Graphics.Dispose();
        }
    }
}
