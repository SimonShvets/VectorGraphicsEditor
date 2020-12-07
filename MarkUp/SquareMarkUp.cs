using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.MarkUp
{
    public class SquareMarkUp : IMarkUp
    {
        public List<PointF> PointList { get; set; }
        public PointF StartPoint { get; set; }
        public int Length
        {
            get
            {
                return PointList.Count;
            }
            set
            {
            }
        }
        public SquareMarkUp()
        {
            PointList = new List<PointF>();
        }
        public PointF[] Calculate()
        {
            return PointList.ToArray();
        }

        public void Update(PointF endPoint)
        {
            int x = (int)StartPoint.X;
            int y = (int)StartPoint.Y;
            int x2 = (int)endPoint.X;
            int y2 = (int)endPoint.Y;
            int a = Math.Abs(x2 - x);
            int b = Math.Abs(y2 - y);
            PointList = new List<PointF>
            {
                 new PointF(x, y),
                 new PointF(x, y2 + a),
                 new PointF(x2 + b, y2 + a),
                 new PointF(x2 + b, y),
            };
        }
    }
}
