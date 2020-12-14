using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public class LensFactory : IToolFactory
    {
        public AbstractTool CreateTool(AbstractSelector abstractSelector)
        {
            return new Lens(new LensSelector());
        }
    }
}
