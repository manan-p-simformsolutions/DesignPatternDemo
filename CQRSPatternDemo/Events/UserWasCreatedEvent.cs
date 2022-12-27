using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Events
{
    public class UserWasCreatedEvent : IEvent
    {
        public string Name { get; }
        public UserWasCreatedEvent(string name)
        {
            Name = name;
        }
    }
}
