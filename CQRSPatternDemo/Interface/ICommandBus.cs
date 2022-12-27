using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPatternDemo.Interface
{
    public interface ICommandBus
    {
        void Send<T>(T Command) where T : ICommand;
    }
}
