using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Controllers
{
    public class CurveController: IFigureController
    {
        private bool _mouseDown = true;
        private bool _mouseDoubleDown = false;
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            if (_mouseDoubleDown == false)
            {
                figure.Update(point);
                canvas.SaveLayer();
                GC.Collect();
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

            if (_mouseDown == false && _mouseDoubleDown == false)
            {
                canvas.CreateLayer();
                if (figure.Points.Count != 0)
                {
                    canvas.Graphics.DrawLine(pen, figure.Points[figure.Points.Count-1],point);
                }
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            //canvas.SaveLayer();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            _mouseDoubleDown = true;
            figure.Markup.AddLines(figure.Points.ToArray());
            canvas.Graphics.DrawPath(pen, figure.Markup);
            canvas.SaveLayer();
            canvas.Graphics.Dispose();
        }
    }
}
