using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.MonitoringDevice
{
    public class GetMonitoringDeviceByIdHandler : IRequestHandler<GetMonitoringDeviceByIdQuery, MonitoringDeviceDto>
    {
        private readonly IMonitoringDeviceRepository _monitoringDeviceRepository;

        public GetMonitoringDeviceByIdHandler(IMonitoringDeviceRepository monitoringDeviceRepository)
        {
            _monitoringDeviceRepository = monitoringDeviceRepository;
        }

        public async Task<MonitoringDeviceDto> Handle(GetMonitoringDeviceByIdQuery request, CancellationToken cancellationToken)
        {
            return await _monitoringDeviceRepository.GetByIdAsync(request.Id);
        }
    }
}
