using AutoMapper;
using HealthApp.Common.Storage.Services;
using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Repositories
{
    public class HealthReportRepository : CrudServiceBase<HealthAppDbContext, HealthReport, HealthReportDto>, IHealthReportRepository
    {
        public HealthReportRepository(HealthAppDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }
    }
}
