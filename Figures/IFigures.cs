﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Figures
{
    public interface IFigures
    {
        Bitmap DrawFigure(Bitmap mainBitmap, Point[] points);
    }
}
