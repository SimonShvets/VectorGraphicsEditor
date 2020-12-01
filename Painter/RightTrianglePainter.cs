using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public class RightTrianglePainter/* : IPainter*/
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            PointF[] points1 = new PointF[3] { pointList[0], pointList[1], new PointF(pointList[0].X, pointList[1].Y) };
            graphics.DrawPolygon(pen, points1);

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
