using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.MonitoringDevice
{
    public class DeleteMonitoringDeviceHandler : IRequestHandler<DeleteMonitoringDeviceCommand>
    {
        private readonly IMonitoringDeviceRepository _iMonitoringDeviceRepository;

        public DeleteMonitoringDeviceHandler(IMonitoringDeviceRepository iMonitoringDeviceRepository)
        {
            _iMonitoringDeviceRepository = iMonitoringDeviceRepository;
        }

        public async Task<Unit> Handle(DeleteMonitoringDeviceCommand request, CancellationToken cancellationToken)
        {
            await _iMonitoringDeviceRepository.DeleteAsync(request.Id);
            return Unit.Value;
        }
    }
}
