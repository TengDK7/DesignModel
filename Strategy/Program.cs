using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;

namespace Strategy
{//策略模式：定义一系列算法，将每个算法封装起来，并让它们可以相互替换，策略模式让算法可以独立于使用它的客户端变化。
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var name = ConfigurationManager.AppSettings["Strategy"];
            AbstractStrategy strategy = (AbstractStrategy)Assembly.Load("Strategy").CreateInstance(name);
            context.SetStrategy(strategy);
            List<int> array = new List<int>() { 1,3,5,7,9,11,13};
            array.ForEach(it => Console.Write($"{it} "));
            var result = context.CalcIntArray(array);
            Console.WriteLine("\n结果为：" + result);
            Console.Read();
        }
    }
}
