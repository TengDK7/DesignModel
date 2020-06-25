using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class StringSearch
    {
        public int SearchString(string source,string target)
        {
            if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(target))
                return -1;
            return source.IndexOf(target);
        }
    }
}
