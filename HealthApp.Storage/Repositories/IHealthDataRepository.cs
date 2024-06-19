using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Repositories
{
    public interface IHealthDataRepository
    {
        Task<Guid> AddAsync(HealthDataDto dto);
        Task UpdateAsync(HealthDataDto dto);
        Task DeleteAsync(Guid id);
        Task<HealthDataDto> GetByIdAsync(Guid id);
        Task<IEnumerable<HealthDataDto>> GetAllAsync();
    }
}
