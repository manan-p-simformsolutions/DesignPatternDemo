using MediatorPatternDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo.Concrete
{
    public class Colleague1 : Colleague
    {
        public Colleague1(Mediator mediator) : base(mediator) { }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 receives message:{message}");
        }
    }
    public class Colleague2 : Colleague
    {
        public Colleague2(Mediator mediator) : base(mediator) { }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives message:{message}");
        }
    }

}
