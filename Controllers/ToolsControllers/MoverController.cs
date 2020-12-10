using System;
using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers.ToolsControllers;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class MoverController: IToolController
    {
        private bool mouseDown;
        public bool toolSelected = true;
        AbstractFigure CurrentFigure;
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures)
        {
            if (toolSelected)
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (figures.FigureSelected(figures[i].StartPoint, figures[i].EndPoint, point, 10))
                    {
                        CurrentFigure = figures[i];
                        mouseDown = true;
                    }
                }
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {
                    canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                    canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                    figures.Move(CurrentFigure, point);
                    CurrentFigure.Painter.DrawFigure(pen, canvas.Graphics, CurrentFigure.Calculate());

                }
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }
    }
}
