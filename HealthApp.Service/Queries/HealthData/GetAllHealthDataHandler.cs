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
    public class GetAllHealthDataHandler : IRequestHandler<GetAllHealthDataQuery, IEnumerable<HealthDataDto>>
    {
        private readonly IHealthDataRepository _iHealthDataRepository;

        public GetAllHealthDataHandler(IHealthDataRepository iHealthDataRepository)
        {
            _iHealthDataRepository = iHealthDataRepository;
        }

        public async Task<IEnumerable<HealthDataDto>> Handle(GetAllHealthDataQuery request, CancellationToken cancellationToken)
        {
            return await _iHealthDataRepository.GetAllAsync();
        }

    }
}
