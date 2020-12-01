using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Painter
{
    public class CurvePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            //graphics.DrawLines(pen, pointList.ConvertToPointF());
        }

        public void StateFixed()
        {
            throw new NotImplementedException();
        }

        public void StateOff()
        {
            throw new NotImplementedException();
        }

        public void StateOn()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
