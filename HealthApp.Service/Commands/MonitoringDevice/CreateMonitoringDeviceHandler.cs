using AutoMapper;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.MonitoringDevice
{
    public class CreateMonitoringDeviceHandler : IRequestHandler<CreateMonitoringDeviceCommand, Guid>
    {
        private readonly IMonitoringDeviceRepository _iMonitoringDeviceRepository;
        private readonly IMapper _mapper;

        public CreateMonitoringDeviceHandler(IMonitoringDeviceRepository iMonitoringDeviceRepository, IMapper mapper)
        {
            _iMonitoringDeviceRepository = iMonitoringDeviceRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateMonitoringDeviceCommand request, CancellationToken cancellationToken)
        {
            var monitoringDevice = _mapper.Map<MonitoringDeviceDto>(request.MonitoringDevice);
            return await _iMonitoringDeviceRepository.AddAsync(monitoringDevice);
        }
    }
}
