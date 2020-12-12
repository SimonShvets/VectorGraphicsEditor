using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Selector;
using System.Drawing;
using VectorGraphicsEditor.Controllers.ToolsControllers;

namespace VectorGraphicsEditor.Tools
{
    public abstract class AbstractTool
    {
        public AbstractSelector Selector { get; protected set; }
        public IToolController ToolController { get; protected set; }

        //public void Move(PointF delta, List<PointF> markup)
        //{
        //    for (int i = 0; i < markup.Count; i++)
        //    {
        //        markup[i] = new PointF(markup[i].X + delta.X, markup[i].Y + delta.Y);
        //    }
        //}
        //RotateSelector - 1я перегрузка в handselector
        public void Rotate(PointF delta, List<PointF> markup)
        {

        }
        //ResizeSelector - 2я перегрузка в handselector
        public void Resize(PointF delta, List<PointF> markup)
        {

        }
    }
}
