using AutoMapper;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HealthData
{
    public class CreateHealthDataHandler : IRequestHandler<CreateHealthDataCommand, Guid>
    {
        private readonly IHealthDataRepository _iHealthDataRepository;
        private readonly IMapper _mapper;

        public CreateHealthDataHandler(IHealthDataRepository iHealthDataRepository, IMapper mapper)
        {
            _iHealthDataRepository = iHealthDataRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateHealthDataCommand request, CancellationToken cancellationToken)
        {
            var healthData = _mapper.Map<HealthDataDto>(request.HealthData);
            return await _iHealthDataRepository.AddAsync(healthData);
        }
    }
}
