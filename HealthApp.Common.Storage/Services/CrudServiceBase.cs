using AutoMapper;
using HealthApp.Common.Storage.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Common.Storage.Services
{
    public class CrudServiceBase<TDbContext, TEntity, TDto>
        where TDbContext : DbContext
        where TEntity : class, IIdentyfiableEntity, new()
        where TDto : class
    {
        protected readonly TDbContext _dbContext;
        protected readonly IMapper _mapper;

        public CrudServiceBase(TDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Guid> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _dbContext.Set<TEntity>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity.Id; 
        }

        public async Task UpdateAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            if (entity != null)
            {
                _dbContext.Set<TEntity>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<TDto> GetByIdAsync(Guid id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _dbContext.Set<TEntity>().ToListAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }
    }
}

