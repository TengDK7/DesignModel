

using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory;
            MobilePhone phone;
            PersonalComputer pc;
            factory = new MIFactory();
            phone = factory.CreatePhone();
            pc = factory.CreatePC();
            Console.WriteLine($"{factory.FactoryName}:{phone.PhoneName}:{pc.PCName}");
            phone.Calling();
            pc.Online();

            Console.WriteLine();
            factory = new AppleFactory();
            phone = factory.CreatePhone();
            pc = factory.CreatePC();
            Console.WriteLine($"{factory.FactoryName}:{phone.PhoneName}:{pc.PCName}");
            phone.Calling();
            pc.Online();
            Console.ReadKey();
        }
    }
}
