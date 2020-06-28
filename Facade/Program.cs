using System;
using System.Configuration;
using System.Reflection;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = ConfigurationManager.AppSettings["BackupClass"];
            var inst = (BackupOperator)Assembly.Load("Facade").CreateInstance(name);
            inst.BackUp(Target.PhotoVidio);
            Console.ReadKey();
        }
    }
}
