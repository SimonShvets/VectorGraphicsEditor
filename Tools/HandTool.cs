using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Selector;
using System.Drawing;
using VectorGraphicsEditor.Controllers.ToolsControllers;

namespace VectorGraphicsEditor.Tools
{
    public class HandTool : AbstractTool
    {
        public HandTool(AbstractSelector handSelector)
        {
            Selector = handSelector;
        }
        //MoveSelector - родной метод в абстрактном классе селектора
        public void Move(PointF delta, List<PointF> markup)
        {
            ToolController = new MoveController();
            for (int i = 0; i < markup.Count; i++)
            {
                markup[i] = new PointF(markup[i].X + delta.X, markup[i].Y + delta.Y);
            }
        }
        //RotateSelector - 1я перегрузка в handselector
        public void Rotate(PointF delta, List<PointF> markup)
        {
            ToolController = new RotateController();

        }
        //ResizeSelector - 2я перегрузка в handselector
        public void Resize(PointF delta, List<PointF> markup)
        {
            ToolController = new MoveController();

        }
    }
}
