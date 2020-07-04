using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Context
    {
        private AbstractStrategy strategy;
        public void SetStrategy(AbstractStrategy fun)
        {
            strategy = fun;
        }
        public long CalcIntArray(List<int> array)
        {
            return strategy.DealwithIntArray(array);
        }
    }
}
