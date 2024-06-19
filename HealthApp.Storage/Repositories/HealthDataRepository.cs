using HealthApp.Storage.Entities;
using HealthApp.Common.Storage.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthApp.Storage.Dtos;
using AutoMapper;

namespace HealthApp.Storage.Repositories
{
    public class HealthDataRepository : CrudServiceBase<HealthAppDbContext, HealthData, HealthDataDto>, IHealthDataRepository
    {
        public HealthDataRepository(HealthAppDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }
    }
}
