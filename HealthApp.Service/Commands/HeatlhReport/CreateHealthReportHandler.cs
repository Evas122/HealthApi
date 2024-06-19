using AutoMapper;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HeatlhReport
{
    public class CreateHealthReportHandler : IRequestHandler<CreateHealthReportCommand, Guid>
    {
        private readonly IHealthReportRepository _iHealthReportRepository;
        private readonly IMapper _mapper;

        public CreateHealthReportHandler(IHealthReportRepository iHealthReportRepository, IMapper mapper)
        {
            _iHealthReportRepository = iHealthReportRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateHealthReportCommand request, CancellationToken cancellationToken)
        {
            var healthReport = _mapper.Map<HealthReportDto>(request.HealthReport);
            return await _iHealthReportRepository.AddAsync(healthReport);
        }
    }
}
