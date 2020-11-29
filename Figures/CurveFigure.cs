using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorGraphicsEditor.Figures
{
    public class CurveFigure : IFigure
    {
        public void DrawFigure(Pen pen, Graphics graphics, PointList pointList)
        {
            graphics.DrawLines(pen, pointList.ConvertToPointF());
        }
    }
}
