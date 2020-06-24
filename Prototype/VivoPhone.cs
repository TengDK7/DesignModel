using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class CPU:ICloneable
    {
        public string Name { get; private set; }
        public CPU(string name)
        {
            Name = name;
        }

        public object Clone()
        {
            CPU cpu = new CPU(Name);//深克隆
            return cpu;
        }
    }
    class VivoPhone : ICloneable
    {
        public CPU Cpu=new CPU("高通骁龙");
        public string Name { get { return "维沃"; } }
        /// <summary>
        /// 深克隆
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            VivoPhone copy = WiseClone();
            copy.Cpu=(CPU)Cpu.Clone();//对cpu进行深克隆
            return copy;
        }
        /// <summary>
        /// 浅克隆
        /// </summary>
        /// <returns></returns>
        public VivoPhone WiseClone()
        {
            return (VivoPhone)this.MemberwiseClone();
        }
    }
}
