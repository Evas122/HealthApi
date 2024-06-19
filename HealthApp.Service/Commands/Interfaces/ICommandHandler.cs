using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.Interfaces
{
    public interface ICommandHandler<in TCommand>
        where TCommand : ICommand
    {
        IAsyncResult Handle(TCommand command);
    }
}
