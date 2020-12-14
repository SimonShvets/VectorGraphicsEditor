using System;
using System.Drawing;
using System.Windows.Forms;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class PipetteController: IToolController
    {
        private bool mouseDown;

        public void MouseDoubleHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
                if (mouseDown)
                {

                }
        }

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = true;          
            if (tool is Pipette)
            {
                ((Pipette)tool).changeColor(pen.Color, pen, point, canvas);
            }          
        }

        public void MouseMoveHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            if (mouseDown)
            {
               
            }
            
        }

        public void MouseUpHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = false;

        }
    }
}
