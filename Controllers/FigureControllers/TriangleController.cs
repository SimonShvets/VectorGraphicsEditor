using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class TriangleController: IFigureController
    {
        private bool _mouseDown = true;
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            figure.Update(point);
            canvas.SaveLayer();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

            if (_mouseDown == false && figure.Points.Count> 0 && figure.Points.Count < 3)
            {
                canvas.CreateLayer();
                if (figure.Points.Count != 0)
                {
                    canvas.Graphics.DrawLine(pen, figure.Points[figure.Points.Count - 1], point);
                }
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            if (figure.Points.Count == 3)
            {
                figure.Markup.AddPolygon(figure.Points.ToArray());
                canvas.Graphics.DrawPath(pen, figure.Markup);
            }
            canvas.SaveLayer();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            canvas.SaveLayer();
        }
    }
}
