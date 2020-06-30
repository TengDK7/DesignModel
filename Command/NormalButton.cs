using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class NormalButton
    {
        private Command command;
        public Command Command
        {
            get { return command; }
            set { command = value; }
        }
        public void ButtonClick()
        {
            Console.WriteLine("模拟事件触发");
            command.Execute();
        }
    }
}
