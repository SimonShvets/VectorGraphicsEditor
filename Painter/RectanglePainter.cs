﻿using System.Drawing;
using System.Drawing.Drawing2D;

namespace VectorGraphicsEditor.Painter
{
    public class RectanglePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path)
        {
            graphics.DrawPath(pen, path);
        }
    }
}

