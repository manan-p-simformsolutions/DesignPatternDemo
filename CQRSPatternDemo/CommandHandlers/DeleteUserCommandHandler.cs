using CQRSPatternDemo.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.CommandHandlers
{
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        public void Handle(DeleteUserCommand command)
        {
            System.Console.WriteLine($"Delete user {command.Name} - handler");
        }
    }
}
