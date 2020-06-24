using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        protected Phone phone = new Phone();
        public abstract void BuildScreen();
        public abstract void BuildBattery();
        public abstract void BuildCamera();
        public abstract void BuildCPU();
        public virtual bool HasCamera { get { return true; } }
        public Phone GetPhone()
        {
            return phone;
        }
    }
    class MiBuilder : Builder
    {
        public override bool HasCamera => true;
        public override void BuildBattery()
        {
            phone.Battery = "小米电池";
        }

        public override void BuildCamera()
        {
            phone.Camera = "小米摄像";
        }

        public override void BuildCPU()
        {
            phone.CPU = "高通处理器";
        }

        public override void BuildScreen()
        {
            phone.Screen = "小米屏幕";
        }
    }
    class AppleBuilder : Builder
    {
        public override bool HasCamera => false;
        public override void BuildBattery()
        {
            phone.Battery = "苹果电池";
        }

        public override void BuildCamera()
        {
            phone.Camera = "苹果摄像";
        }

        public override void BuildCPU()
        {
            phone.CPU = "A10";
        }

        public override void BuildScreen()
        {
            phone.Screen = "苹果屏幕";
        }
    }
}
