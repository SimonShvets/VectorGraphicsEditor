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
        //AbstractFigure ModifiedFigure;
        //int _modifiedFigureIndex;
        //PointF _pullStartPoint = new PointF(0, 0);
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
            //if (ModifiedFigure != null)
            //{
            //    figures.Insert(_modifiedFigureIndex, ModifiedFigure);
            //}
            //canvas.SaveLayer();
        }
    }
}
