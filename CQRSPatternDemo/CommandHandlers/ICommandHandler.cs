using CQRSPatternDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.CommandHandlers
{
    public interface ICommandHandler
    {
    }
    public interface ICommandHandler<T> : ICommandHandler
    where T : ICommand
    {
        void Handle(T command);
    }
}
