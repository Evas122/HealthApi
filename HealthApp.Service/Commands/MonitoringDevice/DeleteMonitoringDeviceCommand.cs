using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.MonitoringDevice
{
    public class DeleteMonitoringDeviceCommand : IRequest
    {
        public Guid Id { get; set; }

        public DeleteMonitoringDeviceCommand(Guid id)
        {
            Id = id;
        }
    }
}
