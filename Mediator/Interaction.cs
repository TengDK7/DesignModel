using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    abstract class Interaction
    {
        public abstract void RelatedChange(Colleague colleague);
    }
    class CompanyInteraction : Interaction
    {
        public Manager Mgr { get; set; }
        public Develop Dev { get; set; }
        public Test Tes { get; set; }
        public override void RelatedChange(Colleague colleague)
        {
            if(colleague is Manager)
            {
                Mgr.AddTask();
                Dev.DevTask();
                Tes.TestTask();

            }
            else if(colleague is Develop)
            {
                Dev.SolveProblem();
                Tes.VerifyProblem();
            }
            else if(colleague is Test)
            {
                Tes.FindProblem();
                Mgr.Supervise();
                Dev.SolveProblem();
            }
        }
    }
}
