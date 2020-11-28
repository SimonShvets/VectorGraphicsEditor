using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class ElipseFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            Rectangle rect = new Rectangle((int)pointList[0].X, (int)pointList[0].Y, (int)(pointList[1].X - pointList[0].X), (int)(pointList[1].Y - pointList[0].Y));
            graphics.DrawEllipse(pen, rect);
        }
    }
}
