using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.HealthData
{
    public class GetHealthDataByIdHandler : IRequestHandler<GetHealthDataByIdQuery, HealthDataDto>
    {
        private readonly IHealthDataRepository _iHealthDataRepository;

        public GetHealthDataByIdHandler(IHealthDataRepository iHealthDataRepository)
        {
            _iHealthDataRepository = iHealthDataRepository;
        }

        public async Task<HealthDataDto> Handle(GetHealthDataByIdQuery request, CancellationToken cancellationToken)
        {
            return await _iHealthDataRepository.GetByIdAsync(request.Id);
        }
    }
}
