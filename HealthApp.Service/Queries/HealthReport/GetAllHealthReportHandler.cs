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
    public class GetAllHealthReportHandler : IRequestHandler<GetAllHealthReportQuery, IEnumerable<HealthReportDto>>
    {
        private readonly IHealthReportRepository _iHealthReportRepository;

        public GetAllHealthReportHandler(IHealthReportRepository iHealthReportRepository)
        {
            _iHealthReportRepository = iHealthReportRepository;
        }

        public async Task<IEnumerable<HealthReportDto>> Handle(GetAllHealthReportQuery request, CancellationToken cancellationToken)
        {
            return await _iHealthReportRepository.GetAllAsync();
        }
    }
}
