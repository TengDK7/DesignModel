using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class CompanyService
    {
        private List<Service> services = new List<Service>() { new SelfService(), new PublicService() };

        public void AddService(Service service)
        {
            services.Add(service);
        }
        public void RemoveService(Service service)
        {
            if (services.Contains(service))
                services.Remove(service);
        }
        public void Accept(AbstractVisitor visitor)
        {
            foreach(var it in services)
            {
                it.Accept(visitor);
            }
        }
    }

}
