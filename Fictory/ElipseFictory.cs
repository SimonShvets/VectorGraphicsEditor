﻿using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class ElipseFictory : IFictory
    {
        public IFigureController CreateController()
        {
            return new ElipseController();
        }

        public IMarkUp CreateMarkUp()
        {
            return new ElipseMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new ElipsePainter();
        }
    }
}
