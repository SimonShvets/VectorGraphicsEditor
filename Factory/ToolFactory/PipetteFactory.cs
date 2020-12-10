using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public class PipetteFactory
    {
        public AbstractTool CreateTool(AbstractSelector abstractSelector)
        {
            return new Pipette(new PipetteSelector());
        }
    }
}
