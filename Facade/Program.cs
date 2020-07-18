using System;
using System.Configuration;
using System.Reflection;

namespace Facade
{
    class Program
    {
        //外观模式提供一个接口统一管理一组在不同类中功能相近的接口
        static void Main(string[] args)
        {
            var name = ConfigurationManager.AppSettings["BackupClass"];
            var inst = (BackupOperator)Assembly.Load("Facade").CreateInstance(name);
            inst.BackUp(Target.PhotoVidio);
            Console.ReadKey();
        }
    }
}
