using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Calculations
{
    public interface ICalculation
    {
        PointList FigureCalculation(PointList pointList);
    }
}
