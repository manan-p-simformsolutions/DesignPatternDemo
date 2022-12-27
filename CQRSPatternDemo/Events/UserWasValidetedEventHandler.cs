using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Events
{
    public class UserWasValidetedEventHandler : IEventHandler<UserWasCreatedEvent>
    {
        public void Handle(UserWasCreatedEvent command)
        {
            System.Console.WriteLine($"User was validated {command.Name} - event");
        }
    }
}
