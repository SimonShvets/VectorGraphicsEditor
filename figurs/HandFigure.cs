﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.figurs
{
    public class HandFigure : IFigure
    {
        public Bitmap DrawFigure(Graphics graphics, Bitmap bitmap, PointF[] points, Pen pen)
        {
            return bitmap;
        }
    }
}