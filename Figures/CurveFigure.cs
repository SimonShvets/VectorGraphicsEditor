﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Figures
{
    public class CurveFigure : IFigures
    {
        public void DrawFigure(Pen pen, Graphics graphics, Bitmap tmpBitmap, PointList pointList)
        {
            graphics.DrawLines(pen, pointList.ConvertToPointF());
        }
    }
}
