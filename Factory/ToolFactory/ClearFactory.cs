﻿using VectorGraphicsEditor.Selector;
using VectorGraphicsEditor.Tools;

namespace VectorGraphicsEditor.Factory.ToolFactory
{
    public class ClearFactory : IToolFactory
    {
        public AbstractTool CreateTool(AbstractSelector abstractSelector)
        {
            return new Pipette(new ClearSelector());
        }
    }
}
