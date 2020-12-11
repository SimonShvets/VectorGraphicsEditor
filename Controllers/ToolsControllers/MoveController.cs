using System;
using System.Drawing;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class MoveController: IToolController
    {
        private bool mouseDown;
        AbstractFigure ModifiedFigure;
        int _modifiedFigureIndex;
        PointF _pullStartPoint = new PointF(0, 0);
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
                if (mouseDown)
                {

                }
        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = true;
            ModifiedFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                if (tool.Selector.Select(figures[i].StartPoint,figures[i].EndPoint, point, 200))
                {
                    ModifiedFigure = figures[i];
                    _pullStartPoint = point;
                    _modifiedFigureIndex = i;
                    figures.Remove(_modifiedFigureIndex);
                    canvas.UndoLayer();
                    break;
                }
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (mouseDown && ModifiedFigure != null)
            {
                PointF delta = new PointF(point.X - _pullStartPoint.X, point.Y - _pullStartPoint.Y);
                _pullStartPoint = point;
                canvas.CreateLayer();
                tool.Move(delta, ModifiedFigure.Markup);
                ModifiedFigure.StartPoint = new PointF(ModifiedFigure.StartPoint.X + delta.X, ModifiedFigure.StartPoint.Y + delta.Y);
                ModifiedFigure.EndPoint = new PointF(ModifiedFigure.EndPoint.X + delta.X, ModifiedFigure.EndPoint.Y + delta.Y);
                ModifiedFigure.Painter.DrawFigure(pen, canvas.Graphics, ModifiedFigure.Markup.ToArray());
            }
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = false;
            if (ModifiedFigure != null)
            {
                figures.Insert(_modifiedFigureIndex, ModifiedFigure);
            }
            canvas.SaveLayer();
        }
    }
}
