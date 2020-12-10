using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Selector;

namespace VectorGraphicsEditor.Tools
{
    public abstract class AbstractTool
    {
        public ISelector Selector { get; protected set; }
    }
}
