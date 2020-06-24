using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class MobilePhone
    {
        public void Calling()
        {
            Console.WriteLine("正在打电话...");
        }
        public abstract string PhoneName
        {
            get;
        }
    }
    class MiPhone : MobilePhone
    {
        public override string PhoneName
        {
            get
            {
                return "小米手机";
            }
        }
    }
    class IPhone : MobilePhone
    {
        public override string PhoneName
        {
            get
            {
                return "苹果手机";
            }
        }
    }
}
