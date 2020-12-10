﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VectorGraphicsEditor.Selector;

namespace VectorGraphicsEditor.Tools
{
    public abstract class AbstractTool
    {
        public AbstractSelector Selector { get; protected set; }
    }
}
