using HealthApp.Service.Queries.HealthData;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.HealthReport
{
    public class GetHealthReportByIdHandler : IRequestHandler<GetHealthReportByIdQuery, HealthReportDto>
    {
        private readonly IHealthReportRepository _iHealthReportRepository;

        public GetHealthReportByIdHandler(IHealthReportRepository iHealthReportRepository)
        {
            _iHealthReportRepository = iHealthReportRepository;
        }

        public async Task<HealthReportDto> Handle(GetHealthReportByIdQuery request, CancellationToken cancellationToken)
        {
            return await _iHealthReportRepository.GetByIdAsync(request.Id);
        }
    }
}
