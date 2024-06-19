using HealthApp.Storage.Dtos;
using HealthApp.Storage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Storage.Repositories
{
    public interface IUserRepository
    {
        Task<Guid> AddAsync(UserDto dto);
        Task UpdateAsync(UserDto dto);
        Task DeleteAsync(Guid id);
        Task<UserDto> GetByIdAsync(Guid id);
        Task<IEnumerable<UserDto>> GetAllAsync();
    }
}
