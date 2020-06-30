using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "right run 100 and left run 100 and back walk 29 and front walk 58";
            Console.WriteLine(test);
            if(NodeMgr.Inst.AnalyzeCommand(test))
            {
                Console.WriteLine(NodeMgr.Inst.Translate());
            }
            Console.ReadKey();
        }
    }
}
