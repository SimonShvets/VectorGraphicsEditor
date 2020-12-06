using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class BrushFictory : IFictory
    {
        public IMarkUp CreateMarkUp()
        {
            return new BrushMarkUp();
        }

        public IPainter CreatePainter()
        {
            return new BrushPainter();
        }
    }
}
