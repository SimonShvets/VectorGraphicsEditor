using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class ElipsePainter /* IPainter*/
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            //Rectangle rect = new Rectangle((int)pointList[0].X, (int)pointList[0].Y, (int)(pointList[1].X - pointList[0].X), (int)(pointList[1].Y - pointList[0].Y));
            //graphics.DrawEllipse(pen, rect);
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
