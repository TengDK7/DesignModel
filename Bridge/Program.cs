using System;
using System.Configuration;
using System.Reflection;

namespace Bridge
{
    class Program
    {
        //桥接模式主要是将一个复杂对象提取出两个独立变化的维度拆分成两个对象，然后靠内部引用关联
        static void Main(string[] args)
        {
            Pen pen = new Brush();
            PenColor color = new Red();
            pen.SetPenColor(color);
            pen.WriteText("中国地图");
            pen = new Crayon();
            color = new Yellow();
            pen.SetPenColor(color);
            pen.WriteText("美国地图");

            Console.WriteLine("通过配置文件：");
            string strpen = ConfigurationManager.AppSettings["Pen"];
            string strcolor = ConfigurationManager.AppSettings["PenColor"];
            pen = (Pen)Assembly.Load("Bridge").CreateInstance(strpen);
            color = (PenColor)Assembly.Load("Bridge").CreateInstance(strcolor);
            pen.SetPenColor(color);
            pen.WriteText("配置文件");

            Console.ReadKey();



        }
    }
}
