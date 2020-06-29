using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class RelatedPerson
    {
        protected RelatedPerson nextperson;
        public void SetNextPerson(RelatedPerson person)
        {
            nextperson = person;
        }
        public abstract void LendMoney(int money);
    }
    class Classsmate : RelatedPerson
    {
        public override void LendMoney(int money)
        {
            if(money<1000)
            {
                Console.WriteLine("同学可以借给你");
            }
            else
            {
                Console.WriteLine("同学没钱");
                nextperson.LendMoney(money);
            }
        }
    }
    class Friend : RelatedPerson
    {
        public override void LendMoney(int money)
        {
            if(money<10000)
            {
                Console.WriteLine("朋友可以借给你");
            }
            else
            {
                Console.WriteLine("朋友没钱");
                nextperson.LendMoney(money);
            }
        }
    }
    class Parent : RelatedPerson
    {
        public override void LendMoney(int money)
        {
            if(money<100000)
            {
                Console.WriteLine("父母可以借给你");
            }
            else
            {
                Console.WriteLine("父母没钱");
                nextperson.LendMoney(money);
            }
        }
    }
    class Bank : RelatedPerson
    {
        public override void LendMoney(int money)
        {
            Console.WriteLine("银行可以借给你");
        }
    }
}
