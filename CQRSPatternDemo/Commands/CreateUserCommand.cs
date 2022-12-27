using CQRSPatternDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Commands
{
    public class CreateUserCommand : ICommand
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public CreateUserCommand(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
