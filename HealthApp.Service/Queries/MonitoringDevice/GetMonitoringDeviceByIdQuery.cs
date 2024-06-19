using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.MonitoringDevice
{
    public class GetMonitoringDeviceByIdQuery :IRequest<MonitoringDeviceDto>
    {
        public Guid Id { get; set; }

        public GetMonitoringDeviceByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
