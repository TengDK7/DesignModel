using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Person
    {
        private MoodStatus moodstatus;
        private int workload=0;


        public void AddWork(int value)
        {
            workload += value;
            RefrshMood();
        }
        public void RemoveWork(int value)
        {
            workload -= value;
            RefrshMood();
        }
        /// <summary>
        /// 状态转换依据实际情况选择放在状态类中或者是环境类中
        /// </summary>
        public void RefrshMood()
        {
            if (workload < 10)
                moodstatus = new HappyMood();
            else if (workload < 100)
                moodstatus = new NormalMood();
            else
                moodstatus = new SadMood();
        }
        public void DoWork()
        {
            moodstatus.DoWork();
        }
    }
}
