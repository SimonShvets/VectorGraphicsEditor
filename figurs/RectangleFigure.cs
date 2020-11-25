using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.figurs
{
    public class RectangleFigure : IFigure
    {
        public Bitmap DrawFigure(Graphics graphics, Bitmap bitmap, PointF[] points, Pen pen)
        {

            PointF[] points1 = new PointF[4] { points[0], new PointF(points[0].X, points[1].Y), points[1], new PointF(points[1].X, points[0].Y) };
            graphics.DrawPolygon(pen, points1);
            return bitmap;
        }

        private PointF[] GetPoints(PointF[] points)
        {
            return points;
        }
    }
}
