using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HeatlhReport
{
    public class CreateHealthReportCommand : IRequest<Guid>
    {
        public HealthReportDto HealthReport { get; set; }

        public CreateHealthReportCommand(HealthReportDto healthReport)
        {
            HealthReport = healthReport;
        }
    }
}
