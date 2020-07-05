using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    abstract class BeAMan
    {
        public void GroupUp()
        {
            Console.WriteLine("首先需要先长大");
        }
        public void LearnKnowledge()
        {
            Console.WriteLine("学习基础知识");
        }
        public abstract void LearnTechnology();
        public void FeedByself()
        {
            Console.WriteLine("可以自立更生");
        }
        public void TheWayToBeAMan()
        {
            GroupUp();
            LearnKnowledge();
            LearnTechnology();
            FeedByself();
        }
    }
    class BeAScientist : BeAMan
    {
        public override void LearnTechnology()
        {
            Console.WriteLine("钻研科学知识,成为科学家");
        }
    }
    class BeAnArtist : BeAMan
    {
        public override void LearnTechnology()
        {
            Console.WriteLine("积累文学素养，成为文学家");
        }
    }
    class BeALoser : BeAMan
    {
        public override void LearnTechnology()
        {
            Console.WriteLine("啥技能也没学好,成为一个失败者");
        }
    }
}
