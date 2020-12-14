using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public class HandFactory : IToolFactory
    {
        public AbstractTool CreateTool(AbstractSelector abstractSelector)
        {
            return new HandTool(new HandSelector());
        }
    }
}
