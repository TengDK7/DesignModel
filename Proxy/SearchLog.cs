using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class SearchLog
    {
        public void Log(int ID,Word word)
        {
            Console.WriteLine($"用户（{ID}）执行一次查询{word}");
        }
    }
}
