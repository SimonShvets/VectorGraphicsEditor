using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public interface IMarkUp
    {
        List<PointF> PointList { get; set; }
        void AddPoint(PointF point);
        PointF[] Calculate();
    }
}
