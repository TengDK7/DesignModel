using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
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
