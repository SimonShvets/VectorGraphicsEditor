using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Selector;
using System.Drawing;
using VectorGraphicsEditor.Controllers.ToolsControllers;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Tools
{
    public class HandTool : AbstractTool
    {
        public HandTool(AbstractSelector handSelector)
        {
            Selector = handSelector;
        }
        public void Move(PointF delta, GraphicsPath markup)
        {
            Matrix translateMatrix = new Matrix();
            translateMatrix.Translate(delta.X, delta.Y);
            markup.Transform(translateMatrix);
        }
        public void Rotate(PointF delta, PointF CentrePoint, GraphicsPath markup)
        {
            Matrix rotateMatrix = new Matrix();
            rotateMatrix.RotateAt(delta.X, CentrePoint);
            markup.Transform(rotateMatrix);
        }
        public void Resize(PointF delta, List<PointF> markup)
        {
            
        }
    }
}
