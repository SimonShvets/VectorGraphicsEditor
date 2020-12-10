using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Selector;
using System.Drawing;

namespace VectorGraphicsEditor.Tools
{
    public class HandTool : AbstractTool
    {
        public HandTool(AbstractSelector handSelector)
        {
            Selector = handSelector;
        }
        //MoveSelector - родной метод в абстрактном классе селектора
        public void Move(bool select, PointF[] markup)
        {

        }
        //RotateSelector - 1я перегрузка в handselector
        public void Rotate(bool select, PointF[] markup)
        {

        }
        //ResizeSelector - 2я перегрузка в handselector
        public void Resize(bool select, PointF[] markup)
        {

        }
    }
}
