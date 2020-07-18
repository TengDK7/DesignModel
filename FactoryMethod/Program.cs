using SimpleFactory;
using System;
using System.Configuration;
using System.Reflection;

namespace FactoryMethod
{
    class Program
    {
        //一个具体工厂创建一个具体产品
        static void Main(string[] args)
        {
            FruitFactory factory;
            FruitProduct product;
            factory = new AppleFactory();
            product = factory.CreateFruit();
            Console.WriteLine("创建了一个{0}，类型是{1}", product.GetProductName(), product.GetProductType());
            factory = new BananaFactory();
            product = factory.CreateFruit();
            Console.WriteLine("创建了一个{0}，类型是{1}", product.GetProductName(), product.GetProductType());
            factory = new OrangeFactory();
            product = factory.CreateFruit();
            Console.WriteLine("创建了一个{0}，类型是{1}", product.GetProductName(), product.GetProductType());
            
            Console.WriteLine();
            Console.WriteLine("通过配置及反射创建对象");
            string typename = ConfigurationManager.AppSettings["TargetType"];
            Console.WriteLine("取配置得到的类型是：{0}", typename);
            factory = (FruitFactory)Assembly.Load("FactoryMethod").CreateInstance(typename);
            product = factory.CreateFruit();
            Console.WriteLine("创建了一个{0}，类型是{1}", product.GetProductName(), product.GetProductType());

            Console.WriteLine();
            Console.WriteLine("通过隐藏工厂方法调用产品方法：");
            var factoryex = new OrangeFactoryEx();
            Console.WriteLine("创建了一个{0}，类型是{1}", factoryex.GetProductName(), factoryex.GetProductType());

            Console.ReadKey();
        }
    }
}
