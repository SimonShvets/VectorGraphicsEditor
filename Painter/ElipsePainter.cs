﻿using System.Drawing;
using System.Drawing.Drawing2D;
namespace VectorGraphicsEditor.Painter
{
    public class ElipsePainter : IPainter
    {
        public void DrawFigure(Pen pen, Graphics graphics, GraphicsPath path)
        {
            graphics.DrawPath(pen, path);
        }
    }
}
