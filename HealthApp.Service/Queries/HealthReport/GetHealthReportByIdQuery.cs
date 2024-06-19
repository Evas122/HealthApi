using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.HealthReport
{
    public class GetHealthReportByIdQuery : IRequest<HealthReportDto>
    {
        public Guid Id { get; set; }

        public GetHealthReportByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
