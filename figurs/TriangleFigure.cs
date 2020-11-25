using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.figurs
{
    public class TriangleFigure : IFigure
    {
        public Bitmap DrawFigure(Bitmap bitmap, PointF[] points)
        {
            return bitmap;
        }

        private PointF[] GetPoints(PointF[] points)
        {
            return points;
        }
    }
}
