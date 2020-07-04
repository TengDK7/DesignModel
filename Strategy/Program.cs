using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;

namespace Strategy
{
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
