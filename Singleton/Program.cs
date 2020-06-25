using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = AppleCompany.Inst;
            c1.MakePhone();
            var c2 = AppleCompany.Inst;
            c2.MakePC();
            Console.WriteLine($"两次制造商是否相同：{c1 == c2}");
            Console.ReadKey();
        }
    }
}
