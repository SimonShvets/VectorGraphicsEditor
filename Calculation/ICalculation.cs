﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Calculation
{
    public interface ICalculation
    {
        PointList FigureCalculation(PointList pointList);
    }
}
