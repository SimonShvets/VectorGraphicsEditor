﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VectorGraphicsEditor.Selector
{
    public abstract class AbstractSelector
    {
       public virtual bool Select(PointF StartPoint, PointF EndPoint, PointF checkPoint, double accuracy)
        {
            return true;
        }
    }
}
