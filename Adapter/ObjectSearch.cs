using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ObjectSearch
    {
        private IntSearch intSearch;
        private StringSearch stringSearch;
        public ObjectSearch()
        {
            intSearch = new IntSearch();
            stringSearch = new StringSearch();
        }
        public int Search(List<int> list,int target)
        {
            return intSearch.SearchInt(list, target);
        }
        public int Search(string source,string target)
        {
            return stringSearch.SearchString(source, target);
        }
    }
}
