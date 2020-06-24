using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            VivoPhone phone = new VivoPhone();
            VivoPhone wiseclone = phone.WiseClone();
            Console.WriteLine($"浅复制之后：对象相等：{phone == wiseclone} CPU相等：{phone.Cpu == wiseclone.Cpu}");
            VivoPhone deepCopy = (VivoPhone)phone.Clone();
            Console.WriteLine($"深复制之后：对象相等：{phone == deepCopy} CPU相等：{phone.Cpu == deepCopy.Cpu}");
            Console.WriteLine();


            OppoPhone oppo = new OppoPhone();
            oppo.Screen = new Screen();
            oppo.Screen.Name = "康宁";

            var wiseoppo = oppo.WiseClone();
            Console.WriteLine($"浅复制之后：对象相等：{oppo == wiseoppo} 屏幕相等：{oppo.Screen == wiseoppo.Screen}");
            var deepoppo = oppo.Clone();
            Console.WriteLine($"序列化复制之后：对象相等：{oppo == deepoppo} 屏幕相等：{oppo.Screen == deepoppo.Screen}");
            Console.ReadKey();
        }
    }
}
