using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Pen
    {
        protected PenColor pencolor;
        public abstract string Name { get; }
        public void SetPenColor(PenColor color)
        {
            pencolor = color;
        }
        public abstract void WriteText(string text);
    }
    class Brush : Pen
    {
        public override string Name => "画笔";

        public override void WriteText(string text)
        {
            Console.WriteLine($"正在使用{pencolor.Color}的{Name}绘制{text}");
        }
    }
    class Crayon : Pen
    {
        public override string Name => "蜡笔";

        public override void WriteText(string text)
        {
            Console.WriteLine($"正在使用{pencolor.Color}的{Name}绘制{text}");
        }
    }
}
