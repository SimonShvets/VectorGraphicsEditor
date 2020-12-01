using System.Drawing;

namespace VectorGraphicsEditor.MarkUp
{
    public interface IMarkUp
    {
        PointList Marks { get; set; }
        PointList Calculate(PointList pointList);
    }
}
