using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
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
