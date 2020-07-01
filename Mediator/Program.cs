using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
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
