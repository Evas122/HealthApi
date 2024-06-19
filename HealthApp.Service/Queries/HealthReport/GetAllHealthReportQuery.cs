using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.HealthReport
{
    public class GetAllHealthReportQuery : IRequest<IEnumerable<HealthReportDto>>
    {
    }
}
