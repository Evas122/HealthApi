using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Commands.HealthData
{
    public class CreateHealthDataCommand : IRequest<Guid>
    {
        public HealthDataDto HealthData { get; set; }

        public CreateHealthDataCommand(HealthDataDto healthData)
        {
            HealthData = healthData;
        }
    }
}
