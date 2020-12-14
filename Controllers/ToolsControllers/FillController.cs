using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Controllers.ToolsControllers
{
    public class FillController : IToolController
    {
        private bool mouseDown;
        AbstractFigure ModifiedFigure;

        public void MouseDownHandle(PointF point, Pen pen, AbstractFigure figure, Canvas canvas, Container figures, AbstractTool tool)
        {
            mouseDown = true;
            ModifiedFigure = null;
            for (int i = 0; i < figures.Length; i++)
            {
                if (tool.Selector.Select(figures[i], point))
                {
                    canvas.CreateLayer();
                    canvas.Graphics.FillPath(new SolidBrush(pen.Color), ModifiedFigure.Markup);
                    GC.Collect();
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
            canvas.SaveLayer();
        }

    }
}
