using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorGraphicsEditor.Selector.HandSelector
{
    public interface IHandSelector: ISelector
    {
        bool Select();
    }
}
