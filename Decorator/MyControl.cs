using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    abstract class MyControl
    {
        public abstract string Name { get;}
        public abstract void Display();
    }

    class MyTextBox : MyControl
    {
        public override string Name { get => "文本框"; }

        public override void Display()
        {
            Console.WriteLine("显示文本框");
        }
    }
    class MyLable : MyControl
    {
        public override string Name { get => "文字"; }

        public override void Display()
        {
            Console.WriteLine("显示文字");
        }
    }
    class MyButton : MyControl
    {
        public override string Name { get =>"按钮"; }

        public override void Display()
        {
            Console.WriteLine("显示按钮");
        }
    }

    class Decoration : MyControl
    {
        private MyControl ctr;

        public override string Name => ctr.Name;

        public override void Display()
        {
            ctr?.Display();
        }
        public Decoration(MyControl control)
        {
            ctr = control;
        }
    }
    class Background : Decoration
    {
        public Background(MyControl control) : base(control) { }
        public override void Display()
        {
            AddBackground();
            base.Display();
        }
        private void AddBackground()
        {
            Console.WriteLine($"给控件{Name}添加背景色");
        }
    }
    class ForeColor : Decoration
    {
        public ForeColor(MyControl control) : base(control) { }
        public override void Display()
        {
            AddForeColor();
            base.Display();
        }
        private void AddForeColor()
        {
            Console.WriteLine($"给控件{Name}添加前景色");
        }
    }

}
