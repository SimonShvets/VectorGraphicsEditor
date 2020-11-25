using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.figurs
{
    public interface IFigure
    {
        Bitmap DrawFigure(Graphics graphics, Bitmap bitmap, PointF[] points, Pen pen);

        //PointF[] GetPoints(PointF[] points);
    }
}
