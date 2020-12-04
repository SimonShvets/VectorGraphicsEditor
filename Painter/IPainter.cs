using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using VectorGraphicsEditor.MarkUp;

namespace VectorGraphicsEditor.Painter
{
    public interface IPainter
    {
        void MouseDownHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas);
        void MouseMoveHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas);
        void MouseUpHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas);
        void MouseDoubleHandle(PointF point, Pen pen, IMarkUp markUp, Canvas canvas);
        void KeyDown();
        void KeyUp();
    }
}
