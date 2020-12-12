using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Selector;

namespace VectorGraphicsEditor.Tools
{
    public class Pipette: AbstractTool
    {
        public Pipette(AbstractSelector handSelector)
        {
            Selector = handSelector;
        }
    }
}
