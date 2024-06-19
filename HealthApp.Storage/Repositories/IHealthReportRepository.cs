using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Repositories
{
    public interface IHealthReportRepository
    {
        Task<Guid> AddAsync(HealthReportDto dto);
        Task UpdateAsync(HealthReportDto dto);
        Task DeleteAsync(Guid id);
        Task<HealthReportDto> GetByIdAsync(Guid id);
        Task<IEnumerable<HealthReportDto>> GetAllAsync();
    }
}
