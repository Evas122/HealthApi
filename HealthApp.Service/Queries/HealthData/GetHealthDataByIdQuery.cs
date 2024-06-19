using HealthApp.Storage.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service.Queries.HealthData
{
    public class GetHealthDataByIdQuery : IRequest<HealthDataDto>
    {
        public Guid Id { get; set; }

        public GetHealthDataByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
