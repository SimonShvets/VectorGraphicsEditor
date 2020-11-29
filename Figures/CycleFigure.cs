using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Figures
{
    public class CycleFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            int x = (int)pointList[0].X;
            int y = (int)pointList[0].Y;
            int x2 = (int)pointList[1].X;
            int y2 = (int)pointList[1].Y;
            int x1 =  (x2 - x);
            int y1 =  (y2 - y);
            Rectangle rect = new Rectangle(x-x1,y-x1,x1*2,x1*2);
            //rect = new Rectangle(10,20,100,200);
            graphics.DrawEllipse(pen, rect);
            
        }
    }
}
