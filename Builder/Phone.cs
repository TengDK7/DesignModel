using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 模拟复杂对象
    /// </summary>
    class Phone
    {
        public object Screen { get; set; }
        public object Battery { get; set; }
        public object Camera { get; set; }
        public object CPU { get; set; }
    }
}
