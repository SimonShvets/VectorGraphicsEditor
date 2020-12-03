using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class RectanglePainter/* : IPainter*/
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointF[] points)
        {
            //PointF[] points1 = new PointF[4] { pointList[0], new PointF(pointList[0].X, pointList[1].Y), pointList[1], new PointF(pointList[1].X, pointList[0].Y) };
            //graphics.DrawPolygon(pen, points1);
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
