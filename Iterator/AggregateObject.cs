using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    abstract class AggregateObject
    {
        protected List<object> list = new List<object>();
        public AggregateObject(List<object> objs)
        {
            list = objs;
        }
        public void AddObj(object obj)
        {
            list.Add(obj);
        }
        public void RemoveObj(object obj)
        {
            list.Remove(obj);
        }
        public List<object> GetObj()
        {
            return list;
        }
        public abstract ObjectIterator CreateIterator();
    }
    class AddressList : AggregateObject
    {
        public AddressList(List<object> objs) : base(objs) { }
        public override ObjectIterator CreateIterator()
        {
            return new AddressIterator(this);
        }
    }
}
