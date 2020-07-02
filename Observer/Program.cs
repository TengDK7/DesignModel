using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstView first = new FirstView();
            SecondView second = new SecondView();
            ThirdView third = new ThirdView();

            TargetData data = new TargetData();
            data.Register(first);
            data.Register(third);

            TargetSign sign = new TargetSign();
            sign.Register(second);
            sign.Register(first);
            sign.Register(third);

            data.ChangeState();
            Console.WriteLine();
            sign.ChangeSign();

            Console.ReadKey();
        }
    }
}
