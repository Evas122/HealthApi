using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Repositories
{
    public interface IMonitoringDeviceRepository
    {
        Task<Guid> AddAsync(MonitoringDeviceDto dto);
        Task UpdateAsync(MonitoringDeviceDto dto);
        Task DeleteAsync(Guid id);
        Task<MonitoringDeviceDto> GetByIdAsync(Guid id);
        Task<IEnumerable<MonitoringDeviceDto>> GetAllAsync();
    }
}
