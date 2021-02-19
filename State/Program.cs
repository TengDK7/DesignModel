using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{//状态模式：允许一个对象在其内部状态改变时改变它的行为，对象看起来似乎修改了它的类。
    class Program
    {
        static void Main(string[] args)
        {
            Person you = new Person();
            you.AddWork(5);
            you.DoWork();
            you.AddWork(50);
            you.DoWork();
            you.AddWork(500);
            you.DoWork();
            Console.ReadKey();
        }
    }
}
