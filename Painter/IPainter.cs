﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Painter
{
    public interface IPainter
    {
        void DrawFigure(Pen pen, Graphics graphics, PointF[] points);
        void StateOn();
        void Update();
        void StateOff();
        void StateFixed();
    }
}