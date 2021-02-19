using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{//迭代器模式：提供一种方法顺序的访问一个聚合对象中的各个元素，而不用暴露该对象的内部表示
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objs = new List<object>() { "杜甫","白居易","苏轼","李白","韩信","嬴政","刘禹锡","柳宗元"};
            AddressList address = new AddressList(objs);
            for(var it=address.CreateIterator();!it.IsLast();it.Next())
            {
                Console.WriteLine(it.CurrentObj());
            }
            Console.ReadKey();
        }
    }
}
