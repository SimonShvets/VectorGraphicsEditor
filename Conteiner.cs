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
        List<IMarkUp> markups { get; set; }
        public Conteiner()
        {
            markups = new List<IMarkUp>();
        }

        public void Add(IMarkUp markUp)
        {
            IMarkUp tmp = markUp;
            markups.Add(tmp);
        }
    }
}
