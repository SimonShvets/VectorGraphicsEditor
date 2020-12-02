using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public interface IMarkUp
    {
        List<PointF> PointList { get; }
        void AddPoint(PointF point);
        PointF[] Calculate();
    }
}
