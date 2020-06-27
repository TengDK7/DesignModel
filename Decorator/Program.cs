using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
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
