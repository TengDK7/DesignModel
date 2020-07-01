using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class Colleague
    {
        protected Interaction Interaction;
        public void SetInteraction(Interaction interaction)
        {
            Interaction = interaction;
        }
        public void ChangeState()
        {
            Interaction.RelatedChange(this);
        }
    }
    class Manager : Colleague
    {
        public void Supervise()
        {
            Console.WriteLine("经理监督工作进度");
        }
        public void AddTask()
        {
            Console.WriteLine("经理添加工作任务");
        }
    }
    class Develop : Colleague
    {
        public void DevTask()
        {
            Console.WriteLine("开发完成任务");
        }
        public void SolveProblem()
        {
            Console.WriteLine("开发修复问题");
        }
        public void MakeTrouble()
        {
            Console.WriteLine("开发制造问题");
        }
    }
    class Test : Colleague
    {
        public void FindProblem()
        {
            Console.WriteLine("测试发现问题");
        }
        public void VerifyProblem()
        {
            Console.WriteLine("测试验证问题");
        }
        public void TestTask()
        {
            Console.WriteLine("测试功能");
        }
    }
}
