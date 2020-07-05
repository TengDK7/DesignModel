using System;
using System.Configuration;
using System.Reflection;

namespace Template
{
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
