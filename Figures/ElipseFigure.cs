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
            //Rectangle rect = new Rectangle((int)points[0].X, (int)points[0].Y, (int)(points[1].X - points[0].X), (int)(points[1].Y - points[0].Y));
            //graphics.DrawEllipse(pen, rect);
        }
    }
}
