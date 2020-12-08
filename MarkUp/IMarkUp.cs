using System.Collections.Generic;
using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public interface IMarkUp
    {
        List<PointF> PointList { get; set; }
        PointF StartPoint { get; set; }
        int Length { get; }
        PointF[] Calculate();
        void Update(PointF endPoint);
    }
}
