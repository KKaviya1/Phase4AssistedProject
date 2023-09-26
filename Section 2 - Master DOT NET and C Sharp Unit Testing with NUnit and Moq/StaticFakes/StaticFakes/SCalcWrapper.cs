using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFakes
{
    public class SCalcWrapper
    {
        public int add(int x, int y)
        {
            return SCalculator.add(x, y);
        }

    }
}

