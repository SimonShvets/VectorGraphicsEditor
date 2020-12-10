using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Selector.HandSelector;
using System.Drawing;

namespace VectorGraphicsEditor.Tools
{
    public class HandTool : AbstractTool
    {
        public HandTool(IHandSelector handSelector)
        {
            Selector = handSelector;
        }
        //MoveSelector
        public void Move(bool select, PointF[] markup)
        {

        }
        //RotateSelector
        public void Rotate(bool select, PointF[] markup)
        {

        }
        //ResizeSelector
        public void Resize(bool select, PointF[] markup)
        {

        }
    }
}
