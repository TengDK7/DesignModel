using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Observer
    {
        public abstract void Update();
    }

    class FirstView : Observer
    {
        public override void Update()
        {
            Console.WriteLine("界面一收到通知，刷新界面");
        }
    }
    class SecondView : Observer
    {
        public override void Update()
        {
            Console.WriteLine("界面二收到通知，刷新界面");
        }
    }
    class ThirdView:Observer
    {
        public override void Update()
        {
            Console.WriteLine("界面三收到通知，刷新界面");
        }
    }
}
