using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public class MinusLensFactory : IToolFactory
    {
        public AbstractTool CreateTool(AbstractSelector abstractSelector)
        {
            return new MinusLens(new MinusLensSelector());
        }
    }
}
