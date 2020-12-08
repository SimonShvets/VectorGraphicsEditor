using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.MarkUp;
using System.Drawing;

namespace VectorGraphicsEditor
{
    public class Conteiner
    {
        List<PointF[]> markups { get; set; }

        public Conteiner()
        {
            markups = new List<PointF[]>();
        }

        public void Add(PointF[] markUp)
        {
            markups.Add(markUp);
        }
    }
}
