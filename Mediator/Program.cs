using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{//中介者模式：定义一个对象封装一系列对象的交互，中介者模式使得各个对象之间不需要显示的相互引用，从而使其耦合度松散，而且让你可以独立地改变他们之间的交互。
    class Program
    {
        static void Main(string[] args)
        {
            var mgr = new Manager();
            var dev = new Develop();
            var tes = new Test();

            var centre = new CompanyInteraction();
            centre.Mgr = mgr;
            centre.Dev = dev;
            centre.Tes = tes;

            mgr.SetInteraction(centre);
            dev.SetInteraction(centre);
            tes.SetInteraction(centre);

            mgr.ChangeState();
            Console.WriteLine();
            dev.ChangeState();
            Console.WriteLine();
            tes.ChangeState();

            Console.ReadKey();
        }
    }
}
