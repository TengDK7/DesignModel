using System;
using System.Configuration;
using System.Reflection;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new MiBuilder();
            PhoneDirector phoneDirector = new PhoneDirector(builder);
            Phone phone;
            phone = builder.GetPhone();
            Console.WriteLine("手机制造之前");
            Console.WriteLine($"{phone.Battery?.ToString()}:{phone.Camera?.ToString()}:{phone.CPU?.ToString()}:{phone.Screen?.ToString()}");

            Console.WriteLine();
            phone = phoneDirector.ConstructPhone();
            Console.WriteLine("手机制造之后");
            Console.WriteLine($"{phone.Battery?.ToString()}:{phone.Camera?.ToString()}:{phone.CPU?.ToString()}:{phone.Screen?.ToString()}");

            Console.WriteLine();
            Console.WriteLine("切换制造商");
            builder = new AppleBuilder();
            phoneDirector.SetBuilder(builder);
            phone = phoneDirector.ConstructPhone();
            Console.WriteLine($"{phone.Battery?.ToString()}:{phone.Camera?.ToString()}:{phone.CPU?.ToString()}:{phone.Screen?.ToString()}");

            Console.WriteLine();
            Console.WriteLine("通过配置文件设置制造商");

            var buildertype = ConfigurationManager.AppSettings["PhoneBuilder"];
            Console.WriteLine($"制造商为：{buildertype}");
            var configbuilder = (Builder)Assembly.Load("Builder").CreateInstance(buildertype);
            phoneDirector.SetBuilder(configbuilder);
            phone = phoneDirector.ConstructPhone();
            Console.WriteLine($"{phone.Battery?.ToString()}:{phone.Camera?.ToString()}:{phone.CPU?.ToString()}:{phone.Screen?.ToString()}");

            Console.ReadKey();
        }
    }
}
