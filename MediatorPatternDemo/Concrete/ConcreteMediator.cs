using MediatorPatternDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternDemo.Concrete
{
    public class ConcreteMediator : Mediator
    {
        public Colleague1 Colleague1 { get; internal set; }
        public Colleague2 Colleague2 { get; internal set; }

        public override void Send(string message, Colleague colleague)
        {
            //colleague.Send(message);
            if (colleague == Colleague1)
                Colleague2.HandleNotification(message);
            else
                Colleague1.HandleNotification(message);
        }
    }
}
