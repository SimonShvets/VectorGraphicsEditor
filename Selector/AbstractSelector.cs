using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Selector
{
    public abstract class AbstractSelector
    {
       public virtual bool Select(PointF StartPoint, PointF EndPoint, PointF checkPoint, double accuracy)
        {
            double x1 = StartPoint.X;
            double y1 = StartPoint.Y;
            double x2 = EndPoint.X;
            double y2 = EndPoint.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;

            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1)) < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }
        protected bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
    }
}
