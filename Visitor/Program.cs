using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{//访问者模式：表示一个作用于某对象结构中的各个元素的操作。访问者模式让你可以在不改变各个元素的类的前提下定义作用与这些元素的新操作。
    class Program
    {
        static void Main(string[] args)
        {
            CompanyService company = new CompanyService();
            AbstractVisitor visitor = new OwnerVisitor();
            company.Accept(visitor);
            Console.WriteLine();
            visitor = new NormalVisitor();
            company.Accept(visitor);
            Console.WriteLine();
            visitor = new PretendVisitor();
            company.Accept(visitor);
            Console.Read();
        }
    }
}
