using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{//观察者模式：定义对象之间的一种一对多的依赖关系，使得每当一个对象状态改变时，其相关依赖对象皆得到通知并被自动更新。
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
