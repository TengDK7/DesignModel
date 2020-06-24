using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class PersonalComputer
    {
        public void Online()
        {
            Console.WriteLine("正在上网...");
        }
        public abstract string PCName
        {
            get;
        }
    }
    class MiPC : PersonalComputer
    {
        public override string PCName
        {
            get
            {
                return "小米笔记本";
            }
        }
    }
    class MacPc : PersonalComputer
    {
        public override string PCName
        {
            get
            {
                return "苹果笔记本";
            }
        }
    }
}
