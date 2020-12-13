using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class HandController : IToolController
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
            Frame frame = new Frame();
            mouseDown = true;
            ModifiedFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i].Markup.IsVisible(point))
                {
                    ModifiedFigure = figures[i];
                    canvas.CreateLayer();
                    frame.CreateFrame(canvas, ModifiedFigure);
                    frame.CreateVertex(canvas);
                    break;
                }
            }
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = false;
            if (ModifiedFigure != null)
            {

            }
            
        }
    }
}
