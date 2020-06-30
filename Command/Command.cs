using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    abstract class Command
    {
        public abstract void Execute();
    }
    class CloseCommand : Command
    {
        private CloseFunction closeFunction;
        public override void Execute()
        {
            closeFunction.CloseFile();
        }
        public CloseCommand()
        {
            closeFunction = new CloseFunction();
        }
    }
    class OpenCommand:Command
    {
        private OpenFunction openFunction;
        public override void Execute()
        {
            openFunction.OpenFile();
        }
        public OpenCommand()
        {
            openFunction = new OpenFunction();
        }
    }
    class DestroyCommand : Command
    {
        private DestroyFunction destroyFunction;
        public override void Execute()
        {
            destroyFunction.DestoryFile();
        }
        public DestroyCommand()
        {
            destroyFunction = new DestroyFunction();
        }
    }
}
