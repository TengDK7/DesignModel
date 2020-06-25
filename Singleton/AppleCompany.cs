using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class AppleCompany
    {
        private AppleCompany()
        {

        }
        private static readonly object lockobj = new object(); 
        private static AppleCompany inst = null;//懒汉式单例，需要加锁避免高并发时创建多个对象
        public static AppleCompany Inst
        {
            get
            {
                if (inst == null)
                {
                    lock(lockobj)
                    {
                        if (inst == null)
                            inst = new AppleCompany();
                    }
                }
                return inst;
            }
        }

        public void MakePhone()
        {
            Console.WriteLine("制造一台苹果手机");
        }
        public void MakePC()
        {
            Console.WriteLine("制造一台苹果笔记本");
        }
    }
}
