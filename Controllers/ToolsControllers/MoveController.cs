using System;
using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class MoveController: IToolController
    {
        private bool mouseDown;
        public bool toolSelected = false;
        AbstractFigure CurrentFigure;
        public void KeyDown()
        {
            throw new NotImplementedException();
        }

        public void KeyUp()
        {
            throw new NotImplementedException();
        }

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {

                }
            }
        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (toolSelected)
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (tool.Selector.Select(figures[i].StartPoint, figures[i].EndPoint, point, 10))
                    {
                        CurrentFigure = figures[i];
                        mouseDown = true;
                    }
                }
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (toolSelected)
            {
                if (mouseDown)
                {
                    canvas.TmpBitmap = (Bitmap)canvas.MainBitmap.Clone();
                    canvas.Graphics = Graphics.FromImage(canvas.TmpBitmap);
                    //tool.Move(CurrentFigure);
                    CurrentFigure.Painter.DrawFigure(pen, canvas.Graphics, CurrentFigure.Calculate());

                }
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
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
