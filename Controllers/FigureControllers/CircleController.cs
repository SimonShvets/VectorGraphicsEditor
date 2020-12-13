using System.Drawing;
using VectorGraphicsEditor.Figure;
using System;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Controllers
{
    public class CircleController: IFigureController
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
            RectangleF boundRect = figure.Markup.GetBounds();
            canvas.Graphics.DrawRectangle(new Pen(Color.Red, 1),
        boundRect.X,
        boundRect.Y,
        boundRect.Height,
        boundRect.Width);
            canvas.Graphics.DrawPath(pen, figure.Markup);
            canvas.SaveLayer();
            canvas.Graphics.Dispose();
        }
    }
}
