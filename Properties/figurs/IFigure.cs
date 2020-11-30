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
        Bitmap DrawFigure(Bitmap bitmap, PointF[] points);

        //PointF[] GetPoints(PointF[] points);
    }
}
