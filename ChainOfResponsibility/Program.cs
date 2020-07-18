using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        //职责链模式将相关对象链接成一条链，使用对象功能时可自动传递给链上的下一个对象，而不用手动每个都调用
        static void Main(string[] args)
        {
            RelatedPerson p1, p2, p3, p4;
            p1 = new Classsmate();
            p2 = new Friend();
            p3 = new Parent();
            p4 = new Bank();

            p1.SetNextPerson(p2);
            p2.SetNextPerson(p3);
            p3.SetNextPerson(p4);

            p1.LendMoney(999);
            Console.WriteLine();
            p1.LendMoney(9999);
            Console.WriteLine();
            p1.LendMoney(99999);
            Console.WriteLine();
            p1.LendMoney(999999);
            Console.ReadKey();
        }
    }
}
