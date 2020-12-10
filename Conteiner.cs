using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Figure;
using System.Drawing;

namespace VectorGraphicsEditor
{
    public class Container
    {
        List<AbstractFigure> Figures { get; set; }
        public int Length 
        { 
            get
            {
                return Figures.Count;
            } 
        }
        public AbstractFigure this[int index]
        {
            get
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return Figures[index];
            }
            set
            {
                if (index >= Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                Figures[index] = value;
            }

        }
        public Container()
        {
            Figures = new List<AbstractFigure>();
        }
        public void Add(AbstractFigure markUp)
        {
            Figures.Insert(0, markUp);
        }

        public void Move(AbstractFigure markUp, PointF delta)
        {

        }
        public bool FigureSelected(PointF startPoint, PointF endPoint, PointF checkPoint, double accuracy)
        {
            double x1 = startPoint.X;
            double y1 = startPoint.Y;
            double x2 = endPoint.X;
            double y2 = endPoint.Y;
            double x = checkPoint.X;
            double y = checkPoint.Y;
            if (CheckInside(x, x1, x2, accuracy) && CheckInside(y, y1, y2, accuracy))
                return Math.Abs((x - x1) * (y2 - y1) - (y - y1) * (x2 - x1))
                < accuracy / 2 * Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            else return false;
        }

        public bool CheckInside(double x, double a, double b, double accuracy)
        {
            if ((x > a - accuracy && x < b + accuracy) || (x > b - accuracy && x < a + accuracy))
                return true;
            else return false;
        }
    }
}
