using MediatorPatternDemo.Abstract;
using MediatorPatternDemo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var c1 = new Colleague1(mediator);
            var c2 = new Colleague2(mediator);

            mediator.Colleague1 = c1;
            mediator.Colleague2 = c2;

            c1.Send("Hello, Good Morning (from c1)");
            c2.Send("Good Morning (from c2)");
        }
    }
}