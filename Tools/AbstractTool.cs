using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Selector;
using System.Drawing;
using VectorGraphicsEditor.Controllers.ToolsControllers;

namespace VectorGraphicsEditor.Tools
{
    public abstract class AbstractTool
    {
        public AbstractSelector Selector { get; protected set; }
        public IToolController ToolController { get; protected set; }

    }
}
