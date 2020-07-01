using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface ObjectIterator
    {
        void Next();
        //void Previous();
        bool IsFirst();
        bool IsLast();
        object CurrentObj();
    }
    class AddressIterator : ObjectIterator
    {
        private AddressList addresslist;
        private List<object> list;
        private int cursor;

        public AddressIterator(AddressList list)
        {
            addresslist = list;
            this.list = list.GetObj();
            cursor = 0;
        }
        public object CurrentObj()
        {
            return list[cursor];
        }

        public bool IsFirst()
        {
            return cursor == 0;
        }

        public bool IsLast()
        {
            return cursor == list.Count;
        }

        public void Next()
        {
            cursor++;
        }

        //public void Previous()
        //{

        //}
    }
}
