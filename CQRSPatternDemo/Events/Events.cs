using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Events
{
    public interface IEvent
    {
    }
    public interface IEventHandler
    {
    }
    public interface IEventHandler<TEvent> : IEventHandler
        where TEvent : IEvent
    {
        void Handle(TEvent @event);
    }
}
