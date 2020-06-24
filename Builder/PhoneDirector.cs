using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class PhoneDirector
    {
        private Builder builder;
        public PhoneDirector(Builder builder)
        {
            this.builder = builder;
        }
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public Phone ConstructPhone()
        {
            builder.BuildBattery();
            if (builder.HasCamera)
                builder.BuildCamera();
            builder.BuildCPU();
            builder.BuildScreen();
            return builder.GetPhone();
        }
    }
}
