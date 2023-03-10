using CQRSPatternDemo.Commands;
using CQRSPatternDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.CommandHandlers
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        private readonly IEventsBus _eventPublisher;
        public CreateUserCommandHandler(IEventsBus eventPublisher)
        {
            _eventPublisher = eventPublisher;
        }
        public void Handle(CreateUserCommand command)
        {
            System.Console.WriteLine($"Create user {command.Name} {command.Surname} - handler");
            _eventPublisher.Publish(new UserWasCreatedEvent(command.Name));
        }
    }
}
