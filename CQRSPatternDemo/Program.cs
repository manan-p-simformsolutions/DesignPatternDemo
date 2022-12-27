using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using CQRSPatternDemo.Commands;

namespace CQRSPatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            IoC.Cofigure();
            var commandBus = new CommandsBus();
            commandBus.Send(new CreateUserCommand("Manan", "Patadiya"));
            //    commandBus.Send(new DeleteUserCommand("Tom"));
        }
    }
}