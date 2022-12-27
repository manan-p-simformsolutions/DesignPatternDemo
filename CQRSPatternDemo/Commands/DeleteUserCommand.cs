using CQRSPatternDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public string Name { get; private set; }
        public DeleteUserCommand(string name)
        {
            Name = name;
        }
    }
}
