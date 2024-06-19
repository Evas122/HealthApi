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
    public class UpdateHealthDataHandler : IRequestHandler<UpdateHealthDataCommand>
    {
        private readonly IHealthDataRepository _iHealthDatarepository;
        private readonly IMapper _mapper;

        public UpdateHealthDataHandler(IHealthDataRepository iHealthDatarepository, IMapper mapper)
        {
            _iHealthDatarepository = iHealthDatarepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateHealthDataCommand request, CancellationToken cancellationToken)
        {
            var healthData = _mapper.Map<HealthDataDto>(request.HealthData);
            await _iHealthDatarepository.UpdateAsync(healthData);
            return Unit.Value;
        }
    }
}
