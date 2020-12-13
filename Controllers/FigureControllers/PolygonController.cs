using System;
using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Controllers
{
    public class PolygonController: IFigureController
    {
        private bool _mouseDown = false;
        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {

        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            figure.StartPoint = point;
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            if (_mouseDown)
            {
                figure.Update(point);
                canvas.CreateLayer();
                canvas.Graphics.DrawPolygon(pen, figure.Points.ToArray());
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            figure.Markup.AddPolygon(figure.Points.ToArray());
            canvas.Graphics.DrawPath(pen, figure.Markup);
            canvas.SaveLayer();
            canvas.Graphics.Dispose();
        }
    }
}
