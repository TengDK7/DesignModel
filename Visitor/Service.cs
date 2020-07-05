using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Service
    {
        public abstract void Accept(AbstractVisitor visitor);
    }
    class PublicService : Service
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    class SelfService : Service
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
