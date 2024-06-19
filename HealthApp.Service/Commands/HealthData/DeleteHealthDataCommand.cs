using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HealthData
{
    public class DeleteHealthDataCommand : IRequest
    {
        public Guid Id { get; set; }

        public DeleteHealthDataCommand(Guid id)
        {
            Id = id;
        }
    }
}
