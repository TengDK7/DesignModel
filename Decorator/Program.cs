using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        //装饰模式：装饰对象与待装饰对象继承自同一个父类，为了可以统一处理装饰前后的对象；装饰对象维护一个待装饰对象
        static void Main(string[] args)
        {
            MyControl ctr = new MyButton();
            ctr = new Background(ctr);//ctr->MyButton
            ctr = new ForeColor(ctr);//ctr->Background
            ctr.Display();//ForeColor.Display->Background.Display->MyButton.Display
            Console.ReadKey();
        }
    }
}
