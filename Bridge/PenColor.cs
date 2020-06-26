using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    interface PenColor
    {
        string Color { get; }
    }
    class Red : PenColor
    {
        public string Color => "红色";
    }
    class Blue : PenColor
    {
        public string Color => "蓝色";
    }
    class Yellow : PenColor
    {
        public string Color => "黄色";
    }
}
