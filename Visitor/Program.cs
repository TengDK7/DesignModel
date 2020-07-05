using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
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
