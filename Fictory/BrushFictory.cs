using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Controllers;
using VectorGraphicsEditor.MarkUp;
using VectorGraphicsEditor.Painter;

namespace VectorGraphicsEditor.Fictory
{
    public class BrushFictory : IFictory
    {
        public IController CreateController()
        {
            return new BrushController();
        }

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
