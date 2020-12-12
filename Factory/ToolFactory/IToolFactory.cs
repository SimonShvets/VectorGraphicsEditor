using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Tools;
using VectorGraphicsEditor.Selector;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public interface IToolFactory
    {
        AbstractTool CreateTool(AbstractSelector abstractSelector);
    }
}
