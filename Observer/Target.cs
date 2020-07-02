using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    abstract class Target
    {
        protected List<Observer> observers = new List<Observer>();
        public void Register(Observer observer) => observers.Add(observer);
        public void UnRegister(Observer observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }
        public void Notify()
        {
            foreach(var ob in observers)
            {
                ob.Update();
            }
        }
    }
    class TargetData : Target
    {
        public void ChangeState()
        {
            Console.WriteLine("目标对象数据更新");
            Notify();
        }
    }
    class TargetSign:Target
    {
        public void ChangeSign()
        {
            Console.WriteLine("目标对象标志更新");
            Notify();
        }
    }
}
