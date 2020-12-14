using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;

namespace VectorGraphicsEditor.Controllers
{
    public class BrushController: IFigureController
    {
        private bool _mouseDown = false;
        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = true;
            figure.Update(point);
            canvas.CreateLayer();
            GC.Collect();
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        { 
            if (_mouseDown)
            {
                PointF prevPoint = figure.Points[figure.Points.Count - 1];
                figure.Update(point);
                canvas.Graphics.DrawLine(pen, prevPoint, point);
                GC.Collect();
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
            figure.Markup.AddLines(figure.Points.ToArray());
            canvas.Graphics.DrawPath(pen, figure.Markup);
            canvas.SaveLayer();
            canvas.Graphics.Dispose();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas)
        {
            _mouseDown = false;
        }
    }
}
