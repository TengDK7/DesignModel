using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class IntSearch
    {
        public int SearchInt(List<int> list,int target)
        {
            if (list == null || list.Count == 0)
                return -1;
            return list.IndexOf(target);
        }
    }
}
