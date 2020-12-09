using System;
using System.Collections.Generic;
using System.Drawing;
using VectorGraphicsEditor.Painter;
using VectorGraphicsEditor.Controllers;

namespace VectorGraphicsEditor.Figure
{
    public class HandFigure : AbstractFigure
    {
        public override List<PointF> Markup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override PointF StartPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override PointF EndPoint { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int Length => throw new NotImplementedException();

        public override PointF[] Calculate()
        {
            throw new NotImplementedException();
        }

        public override void Update(PointF endPoint)
        {
            throw new NotImplementedException();
        }
    }
}
