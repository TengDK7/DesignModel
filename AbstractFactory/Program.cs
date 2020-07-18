

using System;

namespace AbstractFactory
{
    class Program
    {
        //抽象工厂模式主要是一个具体工厂可以创建多种类型具体产品
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
/*
 *核心结构：
 *          抽象类：抽象产品A ->实现类：具体产品A1, 具体产品A2...
 *          抽象类：抽象产品B ->实现类：具体产品B1，具体产品B2...
 *          
 *          抽象类：抽象工厂C ->包含属性：抽象产品A, 抽象产品B
 *             |
 *          实现类：具体工厂C1->包含属性：具体产品A1,具体产品B1
 *          实现类：具体工厂C2->包含属性：具体产品A2,具体产品B2
 * 核心思想：
 *          一个具体工厂可以生产多种具体产品
 *          不同的具体工厂生产不同的具体产品
 *          类似小米公司生产小米手机和小米笔记本
 *          苹果公司生产苹果手机和苹果笔记本
 */
