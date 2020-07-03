using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    abstract class MoodStatus
    {
        public abstract void DoWork();
    }
    class HappyMood : MoodStatus
    {
        public override void DoWork()
        {
            Console.WriteLine("心情愉快，工作效率很高");
        }
    }
    class SadMood : MoodStatus
    {
        public override void DoWork()
        {
            Console.WriteLine("心情悲伤，工作效率低下");
        }
    }
    class NormalMood : MoodStatus
    {
        public override void DoWork()
        {
            Console.WriteLine("心情平稳，工作效率正常");
        }
    }
}
