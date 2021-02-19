using System;
using System.Configuration;
using System.Reflection;

namespace Template
{//模板方法模式：定义一个操作中算法的框架，而将一些步骤延迟到子类中。模板方法模式使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤。
    class Program
    {
        static void Main(string[] args)
        {
            var name = ConfigurationManager.AppSettings["ManStyle"];
            BeAMan person = (BeAMan)Assembly.Load("Template").CreateInstance(name);
            person.TheWayToBeAMan();
            Console.WriteLine();
            person = new BeAScientist();
            person.TheWayToBeAMan();
            Console.WriteLine();
            person = new BeAnArtist();
            person.TheWayToBeAMan();
            Console.WriteLine();
            Console.Read();
        }
    }
}
