using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Events
{
    public class UserWasCreatedEventHandler : IEventHandler<UserWasCreatedEvent>
    {
        public void Handle(UserWasCreatedEvent command)
        {
            System.Console.WriteLine($"User was created {command.Name} - event");
        }
    }
}
