using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    abstract class AbstractStrategy
    {
        public abstract long DealwithIntArray(List<int> array);
    }
    class SumStrategy : AbstractStrategy
    {
        public override long DealwithIntArray(List<int> array)
        {
            if (array == null || array.Count == 0)
                return 0;
            long sum = 0;
            foreach(var it in array)
            {
                sum += it;
            }
            return sum;
        }
    }
    class MultiplyStrategy : AbstractStrategy
    {
        public override long DealwithIntArray(List<int> array)
        {
            if (array == null || array.Count == 0)
                return 0;

            long result = 1;
            foreach(var it in array)
            {
                result *= it;
            }
            return result;
        }
    }

}
