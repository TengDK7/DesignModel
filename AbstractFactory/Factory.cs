using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Factory
    {
        public abstract MobilePhone CreatePhone();
        public abstract PersonalComputer CreatePC();
        public abstract string FactoryName{ get; }
    }
    class MIFactory : Factory
    {
        public override string FactoryName => "小米公司";

        public override PersonalComputer CreatePC()
        {
            return new MiPC();
        }

        public override MobilePhone CreatePhone()
        {
            return new MiPhone();
        }
    }
    class AppleFactory : Factory
    {
        public override string FactoryName => "苹果公司";

        public override PersonalComputer CreatePC()
        {
            return new MacPc();
        }

        public override MobilePhone CreatePhone()
        {
            return new IPhone();
        }
    }
}
