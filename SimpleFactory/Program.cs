using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(FruitType type in Enum.GetValues(typeof(FruitType)))//遍历枚举
            {
                var product = FruitFactory.CreateFruit(type);
                System.Console.WriteLine("现在创建了一个{0}，它的类型是{1}", product.GetProductName(),product.GetProductType());
            }

            System.Console.WriteLine("通过配置文件创建对象：");
            string target = ConfigurationManager.AppSettings["TargetObject"];
            int index;
            if(int.TryParse(target,out index))
            {
                System.Console.WriteLine("配置项结果是{0}", index.ToString());
                var product = FruitFactory.CreateFruit((FruitType)index);
                System.Console.WriteLine("现在创建了一个{0}，它的类型是{1}", product.GetProductName(), product.GetProductType());
            }
            System.Console.ReadKey();//等待按键
        }
    }
}
