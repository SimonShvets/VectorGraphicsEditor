﻿using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.Figure;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Factory
{
    public class IrregularPolygonFactory : IFactory
    {
        public AbstractFigure CreateFigure(IPainter Painter, IFigureController figureController)
        {
            return new IrregularPolygonFigure(new IrregularPolygonPainter(), new IrregularPolygonController());
        }
    }
}
