using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{//解释器模式：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子
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
