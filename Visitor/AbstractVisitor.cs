using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class AbstractVisitor
    {
        public abstract void Visit(PublicService service);
        public abstract void Visit(SelfService service);
    }
    class OwnerVisitor : AbstractVisitor
    {
        public override void Visit(PublicService service)
        {
            Console.WriteLine("管理员访问公有服务，允许所有操作");
        }

        public override void Visit(SelfService service)
        {
            Console.WriteLine("管理员访问私有服务，允许所有操作");
        }
    }
    class NormalVisitor : AbstractVisitor
    {
        public override void Visit(PublicService service)
        {
            Console.WriteLine("普通人员访问公有服务，拥有读取权限");
        }

        public override void Visit(SelfService service)
        {
            Console.WriteLine("普通人员访问私有服务，拒绝访问");
        }
    }
    class PretendVisitor : AbstractVisitor
    {
        public override void Visit(PublicService service)
        {
            Console.WriteLine("可疑人员访问公有服务，拒绝访问");
        }

        public override void Visit(SelfService service)
        {
            Console.WriteLine("可疑人员访问私有服务，拒绝访问");
        }
    }
}
