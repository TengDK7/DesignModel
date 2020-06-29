using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Validate
    {
        public bool IsValid(int ID)
        {
            if(ID>0&&ID<10)
            {
                Console.WriteLine($"用户（{ID}）验证成功！");
                return true;
            }
            else
            {
                Console.WriteLine($"用户（{ID}）验证失败！");
                return false;
            }
        }
    }
}
